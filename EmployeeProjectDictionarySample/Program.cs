namespace EmployeeProjectDictionarySample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> alleMitarbeiter = new()
            {
                { 1, "Anna Müller" },
                { 2, "Ben Schmidt" },
                { 3, "Clara Weber" },
                { 4, "David Fischer" },
                { 5, "Eva Wagner" }
            };

            Dictionary<string, List<int>> projekte = new()
            {
                { "Webshop", new List<int>() },
                { "Mobile App", new List<int>() },
                { "Datenmigration", new List<int>() }
            };

            bool beenden = false;
            while (!beenden)
            {
                Console.Clear();
                Console.WriteLine("=== Hauptmenü ===");
                Console.WriteLine("1) Alle Mitarbeiter im Unternehmen anzeigen");
                Console.WriteLine("2) Alle Projekte mit zugeordneten Mitarbeitern anzeigen");
                Console.WriteLine("3) Mitarbeiter einem Projekt zuordnen");
                Console.WriteLine("0) Beenden");
                Console.Write("Auswahl: ");

                switch (Console.ReadLine())
                {
                    case "1":
                        ZeigeAlleMitarbeiter(alleMitarbeiter);
                        break;
                    case "2":
                        ZeigeProjekte(alleMitarbeiter, projekte);
                        break;
                    case "3":
                        OrdneMitarbeiterZu(alleMitarbeiter, projekte);
                        break;
                    case "0":
                        beenden = true;
                        continue;
                    default:
                        Console.WriteLine("Ungültige Auswahl.");
                        break;
                }

                if (!beenden)
                {
                    Console.WriteLine("\nEnter drücken, um zum Menü zurückzukehren...");
                    Console.ReadLine();
                }
            }
        }

        static void ZeigeAlleMitarbeiter(Dictionary<int, string> alleMitarbeiter)
        {
            Console.WriteLine("\n=== Alle Mitarbeiter ===");
            foreach (KeyValuePair<int, string> mitarbeiter in alleMitarbeiter)
            {
                Console.WriteLine($"{mitarbeiter.Key}) {mitarbeiter.Value}");
            }
        }

        static void ZeigeProjekte(Dictionary<int, string> alleMitarbeiter, Dictionary<string, List<int>> projekte)
        {
            Console.WriteLine("\n=== Projekte ===");
            foreach (KeyValuePair<string, List<int>> projekt in projekte)
            {
                Console.WriteLine($"{projekt.Key}:");
                if (projekt.Value.Count == 0)
                {
                    Console.WriteLine("   (keine Mitarbeiter zugeordnet)");
                }
                foreach (int id in projekt.Value)
                {
                    Console.WriteLine($"   - {alleMitarbeiter[id]}");
                }
            }
        }

        static void OrdneMitarbeiterZu(Dictionary<int, string> alleMitarbeiter, Dictionary<string, List<int>> projekte)
        {
            List<KeyValuePair<int, string>> verfuegbar = alleMitarbeiter
                .Where(m => !projekte.Values.Any(liste => liste.Contains(m.Key)))
                .ToList();

            if (verfuegbar.Count == 0)
            {
                Console.WriteLine("\nKeine verfügbaren Mitarbeiter vorhanden.");
                return;
            }

            Console.WriteLine("\n=== Verfügbare Mitarbeiter ===");
            foreach (KeyValuePair<int, string> mitarbeiter in verfuegbar)
            {
                Console.WriteLine($"{mitarbeiter.Key}) {mitarbeiter.Value}");
            }

            Console.Write("Mitarbeiter-Nr.: ");
            if (!int.TryParse(Console.ReadLine(), out int mitarbeiterNr) || !verfuegbar.Any(m => m.Key == mitarbeiterNr))
            {
                Console.WriteLine("Ungültige Mitarbeiter-Nr.");
                return;
            }

            List<string> projektNamen = projekte.Keys.ToList();
            Console.WriteLine("\n=== Projekte ===");
            for (int i = 0; i < projektNamen.Count; i++)
            {
                Console.WriteLine($"{i + 1}) {projektNamen[i]}");
            }

            Console.Write("Projekt-Nr.: ");
            if (!int.TryParse(Console.ReadLine(), out int projektNr) || projektNr < 1 || projektNr > projektNamen.Count)
            {
                Console.WriteLine("Ungültige Projekt-Nr.");
                return;
            }

            projekte[projektNamen[projektNr - 1]].Add(mitarbeiterNr);
            Console.WriteLine($"{alleMitarbeiter[mitarbeiterNr]} wurde dem Projekt '{projektNamen[projektNr - 1]}' zugeordnet.");
        }
    }
}
