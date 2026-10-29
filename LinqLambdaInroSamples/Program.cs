namespace LinqLambdaInroSamples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> persons = new List<Person>
            {
                new Person { Vorname = "Anna", Nachname = "Müller", Alter = 34 },
                new Person { Vorname = "Ben", Nachname = "Schmidt", Alter = 28 },
                new Person { Vorname = "Clara", Nachname = "Weber", Alter = 45 },
                new Person { Vorname = "David", Nachname = "Fischer", Alter = 22 },
                new Person { Vorname = "Eva", Nachname = "Wagner", Alter = 39 },
                new Person { Vorname = "Felix", Nachname = "Becker", Alter = 31 },
                new Person { Vorname = "Greta", Nachname = "Hoffmann", Alter = 27 },
                new Person { Vorname = "Hans", Nachname = "Schäfer", Alter = 58 },
                new Person { Vorname = "Ida", Nachname = "Koch", Alter = 24 },
                new Person { Vorname = "Jonas", Nachname = "Richter", Alter = 36 },
                new Person { Vorname = "Katharina", Nachname = "Klein", Alter = 41 },
                new Person { Vorname = "Leon", Nachname = "Wolf", Alter = 19 },
                new Person { Vorname = "Mia", Nachname = "Schröder", Alter = 33 },
                new Person { Vorname = "Noah", Nachname = "Neumann", Alter = 26 },
                new Person { Vorname = "Olivia", Nachname = "Schwarz", Alter = 29 },
                new Person { Vorname = "Paul", Nachname = "Zimmermann", Alter = 52 },
                new Person { Vorname = "Quentin", Nachname = "Braun", Alter = 47 },
                new Person { Vorname = "Rosa", Nachname = "Krüger", Alter = 37 },
                new Person { Vorname = "Samuel", Nachname = "Hartmann", Alter = 21 },
                new Person { Vorname = "Tina", Nachname = "Lange", Alter = 43 }
            };


            //Was ist Linq 
            List<Person> allePersonenOver40 = persons.Where(p => p.Alter >= 30 && p.Nachname.StartsWith("S")).ToList();


            //Einzelne Datensätze selektieren 

            //Gebe mir von der Liste Personen die Erste und die Letzte Person
            Person firstPerson = persons.First();
            Person lastPerson = persons.Last();

            //Gebe mir den ersten/letzten Datensatz von einem ergebnis, dass mehrere Treffer hat. 
            Person firstMatch = persons.First(p => p.Alter > 40);
            Person lastMatch = persons.Last(p => p.Alter > 40);

            //Wenn wir unbedingt nur EINEN TREFFER erwarten (Klassiker bei GetBbId) 
            //Single ist sehr streng, wenn das Ergebnis mehr als ein Treffer hat = Fehler. 
            //Fehler wäre: Sequence contains more than one matching element'
            Person singlePerson = persons.Single(p => p.Alter == 58);


            //Multiple Datensätze
            List<Person> allePersonenOver40b = persons.Where(p => p.Alter >= 30 && p.Nachname.StartsWith("S")).ToList();


            //Berechnungen machen

            double durschnittsAlterAllerPersonen = persons.Average(p => p.Alter);


            //Filtern, alle Personen über 30 und davon den Durschnittswert
            double durschnittsAlterAllerPersonenOver30 = persons.Where(p => p.Alter >= 30).Average(p => p.Alter);

            int summierenVonAlter = persons.Sum(p => p.Alter);

            int minimalstesAlter = persons.Min(p => p.Alter);
            int maximalstesAlter = persons.Max(p => p.Alter);

            //String Arbeiten 
            List<Person> allePersonenMit_MANN_im_Nachbanen = persons.Where(p => p.Nachname.ToLower().Contains("mann")).ToList();

            //Sortieren
            List<Person> sorted1 = persons.OrderBy(p=>p.Alter).ToList();


            //Paging
            int seitenGroesse = 5;
            int anzahlSeiten = (int)Math.Ceiling(persons.Count / (double)seitenGroesse);

            for (int seite = 1; seite <= anzahlSeiten; seite++)
            {
                List<Person> seitenInhalt = persons
                    .OrderBy(p => p.Nachname)
                    .Skip((seite - 1) * seitenGroesse)
                    .Take(seitenGroesse)
                    .ToList();

                Console.WriteLine($"Seite {seite} von {anzahlSeiten}:");
                foreach (Person person in seitenInhalt)
                {
                    Console.WriteLine($"  {person.Vorname} {person.Nachname} ({person.Alter})");
                }
            }






        }
    }

    public class Person
    {
        public string Vorname { get; set; }
        public string Nachname {  get; set; }

        public int Alter {  get; set; }
    }
}
