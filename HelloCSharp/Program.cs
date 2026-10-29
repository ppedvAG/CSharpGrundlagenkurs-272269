using System.ComponentModel;

namespace HelloCSharp
{
    internal class Program
    {

        //Main Methode ist der Startpunkt meiner Anwendung (Einstieg) 

        //HelloCSarp.exe -defaultMode
        static void Main(string[] args) //string[] args sind Kommandozeilen Konfigurationen
        {

            //Das ist ein Einzeliges Kommentar

            /* Ein Mehrzeilliges 
             * Kommentar */

            #region Datentypen und Variablen
            //Beispiel zu Datentypen und Variablen


            #region Ganzzahligen Datentypen:
            //short, int und long verwenden ALLE MaxValue und MinValue für ihren Wertenbereich. 
            byte byteVariable = 123;
            //byte.MaxValue und byte.MinValue liefern den höchsten und niedrigsten erlaubten Wert
            byte hoechsterByteWert = byte.MaxValue;
            byte niedrigsterByteWert = byte.MinValue;

            //Wie kann ein Wert ausschauen, den wir zuweisen?

            int einwohnerzahlFrankreich = 72000000;
            int einwohnerzahlDeutschland = 83_000_000; //Beim Kompilieren löscht er die Unterstricher heraus. (83000000)

            //long ist der Größte Datentyp für Ganzzahlig
            #endregion

            #region Gleitkomma
            //Gleitkomma Datentypen: 
            float floatVariabke = 0.35f;
            double doubleVariable = 0.3567;


            //für Geldbeträge verwendet man immer Decimal-Datentyp, weil dieser am genausten ist
            decimal moneyValue = 19.99m; //Muss mit dem Suffix m erstellt werden
            #endregion


            #region String

            int alter = 56;
            string name = "Otto Walkes";


            //cw ist eine Abkkürzung: cw + Tabulator = Console.WriteLine
            //Klassische und eventuell unperformante Methode
            Console.WriteLine("Name: " + name + " Alter: " + alter); //Name: Otto Walkes Alter: 25

            //Aus der C-Zeitalter gibt es die Indexbasierte Ausgabe (Älterer Stil) 
            Console.WriteLine("Name: {0} Alter: {1}",name, alter);

            //Interpolierter String
            Console.WriteLine($"Name: {name} Alter: {alter}");

            //String 
            string ausgabe = $"Name: {name} Alter: {alter}";
            Console.WriteLine(ausgabe);




            #endregion

            #region String mit Escape-Zeichen


            string textausgabe = "Hallo Welt ab jetzt gibt es ein Zeilenumbruch \n hier beginnt die neue Zeilt \t und kann auch Tabulatoren verwenden";


            // ==========================================
            // C# Escape-Sequenzen
            // ==========================================

            // \'  -> Einfaches Anführungszeichen
            char singleQuote = '\'';

            // \"  -> Doppeltes Anführungszeichen
            string text1 = "Er sagte: \"Hallo Welt\"";

            // \\  -> Backslash
            string path = "C:\\Temp\\Datei.txt";

            // \0  -> Nullzeichen (ASCII 0)
            string nullChar = "ABC\0DEF";

            // \a  -> Alarm / Bell (historisch für Lautsprecher)
            string bell = "\a";

            // \b  -> Backspace (ein Zeichen zurück)
            string backspace = "ABC\bD";

            // \f  -> Form Feed (Seitenvorschub)
            string formFeed = "Seite1\fSeite2";

            // \n  -> Neue Zeile (Line Feed)
            string newLine = "Zeile1\nZeile2";

            // \r  -> Wagenrücklauf (Carriage Return)
            string carriageReturn = "ABC\rDEF";

            // \t  -> Tabulator
            string tab = "Name\tAlter";

            // \v  -> Vertikaler Tabulator
            string verticalTab = "A\vB";

            #endregion

            #region Verbatim-String mit @

            //Verbatim String schaltet den Modus von Escape-Zeichen aus!

            //Hier wird der Pfad so verwendet,wie er klassisch dargestellt wurd (Escape-Fuktion wurde Deaktiviert 
            string pfad = @"C:\Windows\Temp\ABC";

            string dicretory = @"SaveGames";
            pfad = @$"c:\GTA6\{dicretory}";
            #endregion


            #region Implizites Casting

            //Implizites Casting bedeutet,
            //Beispiel 1: wir verwenden einen kleine Datentyp z.B ein short und übergeben den Wert der Variabl in einen größeren Ganzzahldatentyp z.b int. 

            //Beispiel 1:
            short shortAge = 47;
            int intAge = shortAge; // hier erfolgt das Implizite Casting. 

            //Beispiel 2: eine Ganzzahl übergeben wir zu einer Gleitkommazahl:

            //Beispiel 2:
            short shortPunktestand = 123;
            double doublePunktestand = shortPunktestand; // hier erfolgt das Implizite Casting. 
            #endregion



            #region Expliztes Casting

            double doubleLength = 123.3;
            int intLength = (int)doubleLength;

            Console.WriteLine(intLength);
            #endregion


            #region Konventierung (String nach Nummerischen Datentypen)

            //Fall 1: Aus Zahl mach ein String
            alter = 50;
            //Die Variable alter=50 wird als String konventiert.  
            string meineAusgabe = "Ich bin " + alter + " Jahre alt.";
            meineAusgabe = "Ich bin " + alter.ToString() + " Jahre alt.";


            //Fall 2: Aus einem String mach einen Text

            string myAge = "56";

            //https://code-maze.com/csharp-intparse-vs-convert-toint32/
            //Variante 1: Mit der Convert-Klasse 
            alter = Convert.ToInt32(myAge);

            //Variante 2: mit int.Parse
            alter = int.Parse(myAge);
            #endregion

            #region Konsoleneingaben

            Console.Write("Bitte gebe das Alter ein: ");

            //Konsoleneingaben sind IMMER vom Typ String
            string consolenInput = Console.ReadLine();

            //Hier wandeln wir den String in ein Integer um (Konventieren) 
            alter = Convert.ToInt32(consolenInput);

            //Wir können noch effizienter den Code in eine Zeile darstellen:
            //alter = int.Parse(Console.ReadLine());

            double doubleValue = double.Parse(consolenInput);
            #endregion

            #region Arimethische Operatoren

            //Feinheiten

            alter = 50;

            //Welches Alter wird hier angezeigt?
            Console.WriteLine(alter++); //50 (danach wird auf 51 erhöht)

            alter = 50;
            Console.WriteLine(++alter);  //51 

            #endregion

            #endregion
        }
    }
}
