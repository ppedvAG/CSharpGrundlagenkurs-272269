using System.Text.Json;

namespace RestAPISample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            HttpClient client = new HttpClient();

            HttpResponseMessage resultMessage = await client.GetAsync("https://jsonplaceholder.typicode.com/todos/");
            resultMessage.EnsureSuccessStatusCode();

            string json = await resultMessage.Content.ReadAsStringAsync();
            List<Todo> todoList = JsonSerializer.Deserialize<List<Todo>>(json) ?? new List<Todo>();


            dataGridView1.DataSource = todoList;

        }

        private void Form1_Resize(object sender, EventArgs e)
        {

        }
    }
}
