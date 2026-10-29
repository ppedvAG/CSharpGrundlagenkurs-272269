namespace SchleifeEnumSwitchSamples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Schleife 

            //Einfache Zählschleife
            Console.WriteLine("Beispiel 1: Zähle von 0 bis 9 = (10 Durchläufe)");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("Beispiel 2: Zähle von 100 bis 0 = (Mit 2er Schritten)");
            for (int y = 100; y > 0; y = y - 2)
            {
                Console.WriteLine(y);
            }

            //for (; true;)
            //{
                //Diese Schleife hat keinen Startwert und keinen Zähler. 
                //Da die Condition immer true ist, bleibt sie eine Endlosschleife

                //dasselbe wie: while (true) 
            //}


            //while und break Sample
            while (true)
            {
                Console.WriteLine("----- Menü -----");
                Console.WriteLine(" (1) Starte Spiel");
                Console.WriteLine(" (2) Optionen");
                Console.WriteLine(" (3) Spiel Verlassen");

                Console.Write("Eingabe: ");
                string input = Console.ReadLine();

                if (input == "1")
                {
                    Console.WriteLine("Starte Spiel...");
                }
                else if (input == "2")
                {
                    Console.WriteLine("Optionen");
                }
                else if (input == "3")
                {
                    break; //Wir brechen die Schleife ab!!! 
                }
                else
                {
                    Console.WriteLine("Unbekannte Eingabe");
                }
            }


            //for + continue

            for (int i = 0; i < 10; i++)
            {
                //Ist die aktuelle Zahl nicht durch 2 Teilbar
                if (i % 2 != 0)
                {
                    continue; //Breche diesen Schleifen-Intervall ab UND gehe in den nächsten Intervall: 

                    //Dieser Code wird niemals ausgeführt
                    Console.WriteLine("Dieser Code wird nicht mehr erreicht");
                }
                   
                
                Console.WriteLine("2er Reihenfolge mit dem Wert: " + i);
               
            }


            string inputNumber;
            int convertedNumber;
            
            //Klassiker für Do-While
            do
            {
                Console.Write("Eingabe einer Zahl: ");
                inputNumber = Console.ReadLine();

            } while (!int.TryParse(inputNumber, out convertedNumber));

            Console.WriteLine("Eingegebene Zahl ist: " + convertedNumber);



            //foreach (blätter einmal komplett durch, kann nur mit break oder continue noch verändert werden. 
            string[] wochentage = { "Mo", "Di", "Mi", "Do", "Fr", "Sa", "So" };

            foreach (string tag in wochentage)
            {
                Console.WriteLine(tag);
            }
            #endregion

            #region Enums

            //Lösung ohne Enums

            string selectedWochentag = wochentage[0]; //Gebe mir den Mo (Montag)
            
            if (wochentage[5] == "Sa")
            {
                Console.WriteLine("ist ein Samstag");
            } 
            else 
                Console.WriteLine("Ist kein Samstag");


            //Lösun mit Enums

            //selektierterWochentag ist So
            Wochentage selektierterWochentag = Wochentage.So;

            //Bei der Prüfung sehen wir sofort, um welche Einträge es sich handelt 
            if (selektierterWochentag == Wochentage.So)
            {

            }


            Jahreszeit jahreszeit = Jahreszeit.Winter;


            if (jahreszeit == Jahreszeit.Winter)
            {
                Console.WriteLine("Warme Jacke kaufen");
            }

            //Bitmask Einstiegsbeispiel:

            //Bitmask Beispiel mit Sporttasche und HasFlag Methode

            SporttascheInhalt tasche =
                  SporttascheInhalt.Handtuch
                | SporttascheInhalt.Trinkflasche
                | SporttascheInhalt.Sportschuhe
                | SporttascheInhalt.TShirt;

            //Handtuch, Trinkflasche, Sportschuhe, TShirt

            //Gehe alle Enum-Einträge durch und frage, ob diese in der Sporttasche sich befinden. 
            foreach (SporttascheInhalt gegenstand in Enum.GetValues<SporttascheInhalt>())
            {
                if (gegenstand == SporttascheInhalt.Nichts)
                    continue;

                if (tasche.HasFlag(gegenstand))
                {
                    Console.WriteLine($"{gegenstand} ist eingepackt.");
                } else
                {
                    Console.WriteLine($"{gegenstand} ist nicht eingepackt.");
                }
            }



            //Bitmask Beispiel A:

            // Tisch aufbauen
            TischGegenstaende tisch =
                  TischGegenstaende.Tasse
                | TischGegenstaende.Teller
                | TischGegenstaende.Gabel
                | TischGegenstaende.Messer;


            Console.WriteLine(tisch);
            // Ausgabe: Tasse, Teller, Gabel, Messer


            //Tasse nehmen wir vom Tisch weg:
            tisch &= ~TischGegenstaende.Tasse;

            Console.WriteLine(tisch);
            // Ausgabe: Teller, Gabel, Messer


            //Eplizites Prüfen, ob die Gabel auf dem Tisch liegt. 

            if ((tisch & TischGegenstaende.Gabel) != 0)
            {
                Console.WriteLine("Gabel liegt noch auf dem Tisch");
            }




            //Bitmask Beispiel B:

            TischGegenstaende ursprungszustand =
                  TischGegenstaende.Tasse
                | TischGegenstaende.Teller
                | TischGegenstaende.Gabel
                | TischGegenstaende.Messer;


            int wert = (int)ursprungszustand;
            Console.WriteLine(wert);


            TischGegenstaende aktuellerTisch = ursprungszustand;

            // Gegenstände mitnehmen
            aktuellerTisch &= ~TischGegenstaende.Tasse;
            aktuellerTisch &= ~TischGegenstaende.Gabel;

            // Differenz bilden
            TischGegenstaende mitgenommen =
                ursprungszustand & ~aktuellerTisch;

            Console.WriteLine(mitgenommen);
            // Ausgabe: Tasse, Gabel



            //Alle mitgenommen Gegenstände ausgeben:
            foreach (TischGegenstaende gegenstand in Enum.GetValues<TischGegenstaende>())
            {
                if (gegenstand == TischGegenstaende.Keine)
                    continue;

                if ((mitgenommen & gegenstand) != 0)
                {
                    Console.WriteLine(gegenstand);
                }
            }



            #endregion

            #region switch

            //Ohne Switch

            selektierterWochentag = Wochentage.Sa;

            //Prüfung 1
            if (selektierterWochentag == Wochentage.Mo)
            {
                
            } //Prüfung 2
            else if (selektierterWochentag == Wochentage.Di)
            {

            }
            else if (selektierterWochentag == Wochentage.Mi || selektierterWochentag == Wochentage.Do || selektierterWochentag == Wochentage.Fr)
            {
                // 3 Prüfungen
            }
            else
            {

            }


            // Mit Switch ist der Vorteil, dass dieser nur 1x prüft und vorher schon Abzweigungen kennt. 

            switch (selektierterWochentag)
            {
                case Wochentage.Mo:
                    Console.WriteLine("Montag");
                    break;
                case Wochentage.Di:
                    Console.WriteLine("Dienstag");
                    break;
                case Wochentage.Mi:
                    Console.WriteLine("Montag");
                    break;
                case Wochentage.Do:
                    Console.WriteLine("Dienstag");
                    break;
                case Wochentage.Fr:
                    Console.WriteLine("Dienstag");
                    break;
                case Wochentage.Sa:
                case Wochentage.So:
                    Console.WriteLine("Wochende");
                    break;
                default:
                    Console.WriteLine("Kein Wochentag gefunden");
                    break;
            }


            #endregion
        }
    }


    public enum Wochentage { Mo=1, Di, Mi, Do, Fr, Sa, So }

    public enum Jahreszeit { Frühling, Sommer, Herbst, Winter }





    [Flags]
    public enum TischGegenstaende
    {
        Keine = 0,
        Tasse = 1,
        Teller = 2,
        Loeffel = 4,
        Gabel = 8,
        Messer = 16,
        Serviette = 32,
        Salzstreuer = 64,
        Pfeffer = 128
    }

    [Flags]
    public enum TischGegenstaendeB
    {
        Keine = 0,

        Tasse = 1 << 0, // 1
        Teller = 1 << 1, // 2
        Loeffel = 1 << 2, // 4
        Gabel = 1 << 3, // 8
        Messer = 1 << 4, // 16
        Serviette = 1 << 5, // 32
        Salzstreuer = 1 << 6, // 64
        Pfeffer = 1 << 7  // 128
    }


    [Flags]
    public enum SporttascheInhalt
    {
        Nichts = 0,
        Handtuch = 1,
        Trinkflasche = 2,
        Sportschuhe = 4,
        TShirt = 8,
        Fitnessband = 16,

        Trikot = 32,
        Stirnband = 64,

    }
}
