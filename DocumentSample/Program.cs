namespace DocumentSample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Hier können ALLE SQL-Lite Versionen beinhaltet werden
            List<SQLiteDatabase> alleSQLiteDatenbankVersionenListe = new List<SQLiteDatabase>();


            //Alle 4 Datenbanken sind geraden in unseren ultimativen Editor geöffnet.
            alleSQLiteDatenbankVersionenListe.Add(new SQLite1());
            alleSQLiteDatenbankVersionenListe.Add(new SQLite2());
            alleSQLiteDatenbankVersionenListe.Add(new SQLite3());
            alleSQLiteDatenbankVersionenListe.Add(new SQLite3());

            //Wir wollen aber das Hauptprogramm schließen und alle Datenbanken sollen automatisch den letzten Stand speichern und die Connection schließen. 

            foreach (SQLiteDatabase database in alleSQLiteDatenbankVersionenListe)
            {
                database.SaveFile("Zufälliger Dateinamen"); //Egal
                database.CloseConnection();
            }



            //Version 2: Wir haben jetzt mehr Dateitypen vorhanden

            List<DocumentBase> documentBases = new List<DocumentBase>();
            documentBases.Add(new Word());
            documentBases.Add(new Excel());
            documentBases.Add(new PDFDocument());

            documentBases.Add(new SQLite1());
            documentBases.Add(new SQLite2());
            documentBases.Add(new SQLite3());


            foreach (DocumentBase currentDocument in documentBases)
            {
                currentDocument.SaveFile("Speichere in eine Datei");

                //is eine Typprüfung
                if (currentDocument is SQLiteDatabase sqliteDocument)
                {
                    sqliteDocument.CloseConnection();
                }
                
            }
        }


        //OfficeSuite kann alle Datentypen, darstellen, bearbeiten und laden/speichern
        //
        // Word, Excel, JPG, PDF, PNG, MP3, SQLite-MitVersion
        public abstract class DocumentBase
        {
            public abstract void SaveFile(string filename);

            public abstract void LoadFile(string filename);
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

        public class PDFDocument : DocumentBase
        {
            public override void LoadFile(string filename)
            {
                Console.WriteLine("PDFDocument wird geladen");
            }

            public override void SaveFile(string filename)
            {
                Console.WriteLine("PDFDocument wird gespeichert");
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


    }
}
