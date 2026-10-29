using PrimzahlenGenerator;

namespace DelegateWithCallback
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrimzahlComponent primzahlComponent = new PrimzahlComponent();
            
            
            FoundPrimzahlCallback foundPrimzahlCallback = new FoundPrimzahlCallback(AusgabeGefundenePrimzahl);
            FinishPrimzahlSucheCallback finishPrimzahlSucheCallback = new FinishPrimzahlSucheCallback(PrimzahlenSucheStatus);

            primzahlComponent.SearchPrimzahlen(1, 10_000, foundPrimzahlCallback, finishPrimzahlSucheCallback);
        }

        public static void AusgabeGefundenePrimzahl(int primzahl)
        {
            Console.WriteLine(primzahl);
        }

        public static void PrimzahlenSucheStatus(string message)
        {
            Console.WriteLine(message);
        }
    }

    


}
