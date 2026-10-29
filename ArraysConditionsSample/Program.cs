namespace ArraysConditionsSample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Klassische Schreibweise
            int[] zahlenA = new int[] {2,4,6,8,10}; // Länge = 5, maximale Index 4
            Console.WriteLine(zahlenA[4]); //10 wird ausgegeben
            Console.WriteLine(zahlenA.Length); //Länge eines Arrays (anhand der Felderanzahl)


            //Verkürzte Schreibweise
            int[] zahlenB = { 1, 3, 5, 7, 9 };


            //leeres Array von 5 Felder; 
            int[] zahlenC = new int[5];
            //Erstes Array-Feld beginnt mit dem Index '0'
            
            //Werte werden in das Array initialisiert. 
            zahlenC[0] = 1;
            zahlenC[1] = 2;
            zahlenC[2] = 3;
            zahlenC[3] = 4;
            zahlenC[4] = 5;


            string[] words = { "Hallo", "Welt" };


            // int[] zahlenA = new int[] {2,4,6,8,10}; 

            bool isVorhanden = zahlenA.Contains(6); //Ist der Wert 6 im Array enthalten? 
            isVorhanden = zahlenB.Contains(5); //Ist der Wert 6 im Array enthalten? 


            //Was ist die höchste und niedrigste Zahl im Array
            int hoechsteZahl = zahlenA.Max();
            int niedrigsteZahl = zahlenA.Min();




            //IF-Statement 


            int alter = 18;
            bool hatFahrlizenz = true;

            if (alter >= 18 && hatFahrlizenz)
            {
                Console.WriteLine("Er darf Auto fahren");
            }

            string wochentag = "Samstag";

            if (wochentag == "Montag"   ||  
                wochentag == "Dienstag" || 
                wochentag == "Mittwoch" || 
                wochentag == "Donnerstag" || 
                wochentag == "Freitag")
            {
                Console.WriteLine("Arbeitstag");
            } else if (wochentag == "Samstag" ||  wochentag == "Sonntag")
            {
                Console.WriteLine("Wochenende");
            } else
            {
                Console.WriteLine("Unbekannter Wochentag");
            }


            //Tenär - If 

            string backgroundColorSettings = "orange";
            string foreColorSettings = "red";
            //Condition ? True-Block : False-Block 

            //Prüfen ob backgroundColorSettings einen Wert aufweist, wenn ja wird dieser zurückgegeben. Wenn Nein = Default-Wert wird gesetzt: Default_White
            string backgroundColor = !string.IsNullOrWhiteSpace(backgroundColorSettings) ? backgroundColorSettings : "Default_White";
            string foreColor = !string.IsNullOrWhiteSpace(foreColorSettings) ? foreColorSettings : "Default_Grey";

            //Später in ASP.NET Core oder auch in Apps kann man mit der IConfiguration arbeiten (appsetting.json) 
            //IConfiguration configuration .....

            //string sqlConnection = configuration["SqlServer"] != null ? configuration["SqlServer"] : throw new Exception();
            Console.WriteLine(backgroundColor);


        }
    }
}
