using PrimzahlenComponent;
using System.Text;
using System.Text.Json;

namespace ExceptionHandlingSample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //try-block besagt, dass innerhalb des Code-Blocks Fehler entstehen können. 
            try
            {
                textBox3.Text = "";
                double zahl1 = Convert.ToDouble(textBox1.Text);

                double zahl2 = Convert.ToDouble(textBox2.Text);

                double result = zahl1 / zahl2;

                textBox3.Text = result.ToString();

            }
            catch (FormatException ex)
            {
                textBox3.Text = ex.Message;
            }
            catch (DivideByZeroException ex)
            {
                textBox3.Text = ex.Message;
            }
            catch (Exception ex)
            {
                textBox3.Text = ex.Message;
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            FileStream? fileStream = null;
            try
            {
                textBox3.Text = string.Empty;
                string path = Path.Combine(AppContext.BaseDirectory, "MovieTitles.json");

                fileStream = new FileStream(path, FileMode.Open, FileAccess.Read);
                byte[] buffer = new byte[fileStream.Length];
                fileStream.ReadExactly(buffer);
                string json = Encoding.UTF8.GetString(buffer);

                List<Movie> movies = JsonSerializer.Deserialize<List<Movie>>(json) ?? new List<Movie>();

                foreach (Movie movie in movies)
                {
                    textBox3.AppendText($"{movie.Title} ({movie.Year}){Environment.NewLine}");
                }
            }
            catch (FileNotFoundException ex)
            {
                textBox3.Text = $"Datei nicht gefunden: {ex.Message}";
            }
            catch (JsonException ex)
            {
                textBox3.Text = $"Fehler beim Einlesen des JSON: {ex.Message}";
            }
            catch (Exception ex)
            {
                textBox3.Text = $"Fehler beim Einlesen: {ex.Message}";
            }
            finally
            {
                //finally-Block wird im Fehler und im Erfolgsfall Immer aufgerufen
                //In Finally werden Ressourcen aufgeräumt (Zufgriff auf DB oder Datei)

                fileStream?.Close();
            }


        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                PrimzahlComponent primzahlComponent = new PrimzahlComponent();
                primzahlComponent.SearchPrimzahl(2000);
            }
            catch (EigenePrimzahlException ex)
            {
                textBox3.Text += ex.Message;

                textBox4.Text += ex.Message;
                textBox5.Text += ex.StackTrace;
                textBox6.Text += ex.ToString();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
