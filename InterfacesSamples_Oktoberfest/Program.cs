namespace InterfacesSamples_Oktoberfest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Besucher besucher = new Besucher() { Alter = 17, Name = "Otto Walkes" };

            Oktoberfest oktoberfest = new Oktoberfest();
            oktoberfest.BesucheAlle(besucher);


            List<DocumentBase> documentBases = new List<DocumentBase>();
            documentBases.Add(new Word());
            documentBases.Add(new Excel());
            documentBases.Add(new PDFDocument());

            documentBases.Add(new SQLite1());
            documentBases.Add(new SQLite2());
            documentBases.Add(new SQLite3());

            foreach (DocumentBase currentDocument in documentBases)
            {
                if (currentDocument is IWatermark documentWithWatermark)
                {
                    documentWithWatermark.SetWatermark("PPEDV AG");
                }
            }
        }
    }
    #region Beispiel OktoberFest
    public class Besucher
    {
        public string Name { get; set; }
        public int Alter {  get; set; }
    }

    public class Oktoberfest
    {
        List<OktoberfestStandBase> alleOktoberfestStände;

        public Oktoberfest()
        {
            alleOktoberfestStände = new List<OktoberfestStandBase>();
            alleOktoberfestStände.Add(new Streichelzoo() { Betreiber = "Tiroler Bergbauer", Mitarbeiteranzahl = 2, AnzahlTiere = 6 });
            alleOktoberfestStände.Add(new AutoScooter() { Betreiber = "Autoscooter Freund", AnzahlAutos = 15, Mitarbeiteranzahl = 4 });
            alleOktoberfestStände.Add(new Wildwasserbahn() { Betreiber = "Rheinfahrt", Mitarbeiteranzahl = 1, LaengeDerStrecke = 120, AnzahlDerWagen = 10 });
            alleOktoberfestStände.Add(new HöchsteAchterbahnDerWelt() { Betreiber = "Heaven GmbH", Mitarbeiteranzahl = 1, LaengeDerStrecke = 120, AnzahlDerWagen = 10 });
            alleOktoberfestStände.Add(new Karussel() { Betreiber = "Karussel AG", Mitarbeiteranzahl = 1, AnzahlDerSitzpläte = 10 });
            alleOktoberfestStände.Add(new SpiegelCabinett() { Betreiber = "Uhrenmacher AG", AnzahlRäume = 10 , Mitarbeiteranzahl = 5});
            alleOktoberfestStände.Add(new HorrorCabinett() { Betreiber = "Fredy Krüger", AnzahlDerSchockmomente=40, AnzahlRäume=10, Mitarbeiteranzahl=5});

        }

        public void BesucheAlle(Besucher besucher)
        {
            foreach (OktoberfestStandBase aktuellerStand in alleOktoberfestStände)
            {
                //Hier müssen wir überprüfen, ob der aktuelleStand eine IFSK18 Prüfung verwendet. 

                if (aktuellerStand is IFSK18 fsk18Stand)
                {
                    if (fsk18Stand.IsOver18(besucher))
                    {
                        Console.WriteLine($"{besucher.Name} darf {aktuellerStand.Betreiber} besuchen");
                    }
                    else
                    {
                        Console.WriteLine($"{besucher.Name} ist zu jung für {aktuellerStand.Betreiber}");
                    }
                }
                else
                {
                    Console.WriteLine($"{besucher.Name} darf {aktuellerStand.Betreiber} besuchen");
                }
            }
        }


    }


    //Interface mit nur Methoden-Signatur und ohne Funktions-Body muss in der jeweiligen Klasse ausimplementiert werden (genause wie eine abstrakte Methode)
    public interface IFSK18
    {
        //Alle Methoden in einem Interface werden publich 
        bool IsOver18(Besucher besucher)
        {
            return besucher.Alter >= 18; //Wenn 18 oder älter = true. Unter 18 = false
        }
    }


    public class OktoberfestStandBase
    {
        public string Betreiber { get; set; }
        public int Mitarbeiteranzahl {  get; set; }
        //public int Quatratmeter { get; set; }
    }

    public class Streichelzoo : OktoberfestStandBase
    {
        public int AnzahlTiere { get; set; }
    }

    public class AutoScooter : OktoberfestStandBase
    {
        public int AnzahlAutos {  get; set; }
    }

    public class RollercosterBase : OktoberfestStandBase
    {
        public int LaengeDerStrecke {  get; set; }
        public int AnzahlDerWagen {  get; set; }
    }

    public class Wildwasserbahn : RollercosterBase
    {
        //...
    }

    public class HöchsteAchterbahnDerWelt : RollercosterBase, IFSK18
    {
        //...
    }

    public class SpiegelCabinett : OktoberfestStandBase
    {
        //Anzahl der Räume 
        public int AnzahlRäume {  get; set; }
    }

    public class HorrorCabinett : OktoberfestStandBase, IFSK18
    {
        public int AnzahlRäume { get; set; }
        public int AnzahlDerSchockmomente {  get; set; }

       
    }

    public class Karussel : OktoberfestStandBase
    {
        public int AnzahlDerSitzpläte {  get; set; }
    }
    #endregion


    #region Dokument-Beispiel
    //OfficeSuite kann alle Datentypen, darstellen, bearbeiten und laden/speichern
    //
    // Word, Excel, JPG, PDF, PNG, MP3, SQLite-MitVersion
    public abstract class DocumentBase
    {
        public abstract void SaveFile(string filename);

        public abstract void LoadFile(string filename);
    }

    public interface IWatermark
    {
        void SetWatermark(string text);
    }

    public class Excel : DocumentBase
    {
        public override void LoadFile(string filename)
        {
            Console.WriteLine("Excel-Dokument wird geladen");
        }

        public override void SaveFile(string filename)
        {
            Console.WriteLine("Excel-Dokument wird gespeichert");
        }
    }

    public class JPG : DocumentBase, IWatermark
    {
        public override void LoadFile(string filename)
        {
            Console.WriteLine("JPG-Dokument wird geladen");
        }

        public override void SaveFile(string filename)
        {
            Console.WriteLine("JPG-Dokument wird gespeichert");
        }

        public void SetWatermark(string text)
        {
            Console.WriteLine("Setze Wasser in das JPG Format");
        }
    }

    public class Word : DocumentBase
    {
        public override void LoadFile(string filename)
        {
            Console.WriteLine("Word-Dokument wird geladen");
        }

        public override void SaveFile(string filename)
        {
            Console.WriteLine("Word-Dokument wird gespeichert");
        }
    }

    public class PDFDocument : DocumentBase, IWatermark
    {
        public override void LoadFile(string filename)
        {
            Console.WriteLine("PDFDocument wird geladen");
        }

        public override void SaveFile(string filename)
        {
            Console.WriteLine("PDFDocument wird gespeichert");
        }

        public void SetWatermark(string text)
        {
            Console.WriteLine("Setzte in PDF Format ein Wasserzeichen");
        }
    }

    public class PNGDocument : DocumentBase
    {
        public override void LoadFile(string filename)
        {
            Console.WriteLine("PNGDocument wird geladen");
        }

        public override void SaveFile(string filename)
        {
            Console.WriteLine("PNGDocument wird gespeichert");
        }
    }

    public class JPGDocument : DocumentBase
    {
        public override void LoadFile(string filename)
        {
            Console.WriteLine("JPGDocument wird geladen");
        }

        public override void SaveFile(string filename)
        {
            Console.WriteLine("JPGDocument wird gespeichert");
        }
    }



    public abstract class SQLiteDatabase : DocumentBase
    {
        public override void LoadFile(string filename)
        {
            Console.WriteLine("SQLite Datenbank wird geladen");
        }

        public override void SaveFile(string filename)
        {
            Console.WriteLine("SQLite Datenbank wird gespeichert");
        }


        public abstract void CloseConnection();
        public abstract void OpenConnection();
    }

    public class SQLite1 : SQLiteDatabase
    {


        public override void LoadFile(string filename)
        {
            Console.WriteLine("SQLite1 wird geladen");
        }

        public override void SaveFile(string filename)
        {
            Console.WriteLine("SQLite1 wird gespeichert");
        }

        public override void OpenConnection()
        {
            Console.WriteLine("SQLite 1 wird geöffnet");
        }
        public override void CloseConnection()
        {
            Console.WriteLine("SQLite 1 wird geschlossen");
        }
    }

    public class SQLite2 : SQLiteDatabase
    {
        public override void LoadFile(string filename)
        {
            Console.WriteLine("SQLite2 wird geladen");
        }

        public override void SaveFile(string filename)
        {
            Console.WriteLine("SQLite2 wird gespeichert");
        }

        public override void OpenConnection()
        {
            Console.WriteLine("SQLite 2 wird geöffnet");
        }
        public override void CloseConnection()
        {
            Console.WriteLine("SQLite 2 wird geschlossen");
        }
    }

    public class SQLite3 : SQLiteDatabase
    {
        public override void LoadFile(string filename)
        {
            Console.WriteLine("SQLite3 wird geladen");
        }

        public override void SaveFile(string filename)
        {
            Console.WriteLine("SQLite3 wird gespeichert");
        }
        public override void OpenConnection()
        {
            Console.WriteLine("SQLite 3 wird geöffnet");
        }
        public override void CloseConnection()
        {
            Console.WriteLine("SQLite 3 wird geschlossen");
        }
    }

    #endregion
}
