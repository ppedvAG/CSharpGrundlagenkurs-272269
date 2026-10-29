namespace TyppruefungSample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<DocumentBase> documentBases = new List<DocumentBase>();
            documentBases.Add(new Word());
            documentBases.Add(new Excel());
            documentBases.Add(new PDFDocument());

            documentBases.Add(new SQLite1());
            documentBases.Add(new SQLite2());
            documentBases.Add(new SQLite3());


            foreach (DocumentBase currentDocument in documentBases)
            {
                //Alte Variante C++ angelehnte Lösung


                //Wir prüfen: Ist currentDocument ein Word-Dokument
                if (currentDocument.GetType() == typeof(SQLite1))
                {
                    Console.WriteLine("CurrentType ist SQLite in Version 1");

                    //Zugriff auf das Objekt
                    SQLite1 currentSQLite = (SQLite1)currentDocument;


                    //Referenztypen, vergleichen immer die selbe Speicheradresse
                    if (currentSQLite == currentDocument)
                    {
                        Console.WriteLine("Ist das selbe, aber eben nur mit unterschiedlichen Funktionsumfang");
                    }
                }


                //Wir prüfen: Ist currentDocument ein Word-Dokument
                if (currentDocument.GetType() == typeof(SQLiteDatabase))
                {
                    Console.WriteLine("CurrentType ist definitiv eine SQLite Datenbank, welche Version weiß ich nicht");
                }

                if (currentDocument.GetType() == typeof(DocumentBase))
                {
                    Console.WriteLine("CurrentType ist definitiv ein Document");
                }

                if (currentDocument.GetType() == typeof(Word))
                {
                    Console.WriteLine("CurrentType ist definitiv ein Document");
                }

                //Wir prüfen auf SQLiteDatabase
                if (currentDocument is SQLiteDatabase)
                {
                    Console.WriteLine("CurrentType ist definitiv ein Document");
                }

                if (currentDocument is SQLite1 sqLite1)
                {
                    Console.WriteLine("CurrentType ist definitiv ein Document");

                    if (currentDocument == sqLite1)
                    {
                        Console.WriteLine("Ist die selber Speicheradresse");
                    }
                }
                 
                if (currentDocument is DocumentBase)
                {
                    Console.WriteLine("CurrentType ist definitiv ein Document");
                }

                

            }
        }
    }


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
