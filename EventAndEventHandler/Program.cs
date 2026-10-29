using static System.Runtime.InteropServices.JavaScript.JSType;

namespace EventAndEventHandler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Event-Delegates
            PrimzahlenComponentWithDelegateEvents primzahlenComponentWithDelegateEvents = new PrimzahlenComponentWithDelegateEvents();

            primzahlenComponentWithDelegateEvents.PrimzahlGefundenDelegate += PrimzahlenComponentWithDelegateEvents_PrimzahlGefundenDelegate;
            primzahlenComponentWithDelegateEvents.SucheAbgeschlossenDelegate += PrimzahlenComponentWithDelegateEvents_SucheAbgeschlossenDelegate;
            primzahlenComponentWithDelegateEvents.SearchPrimzahlen(1, 10_000);
            #endregion

            #region EventHandler
            PrimzahlGeneratorWithEventHandler primzahl = new();
            primzahl.GenericPercentValueChanged += Primzahl_GenericPercentValueChanged;
            primzahl.GenericProcessCompleted += Primzahl_GenericProcessCompleted;

            primzahl.StartProcess();
            #endregion

        }

        private static void Primzahl_GenericProcessCompleted(object? sender, string e)
        {
            Console.WriteLine(e);
        }

        private static void Primzahl_GenericPercentValueChanged(object? sender, int e)
        {
            Console.WriteLine(e);
        }
        #region Event-Delegates - Beispiel-Methoden
        private static void PrimzahlenComponentWithDelegateEvents_SucheAbgeschlossenDelegate1(string message)
        {
            throw new NotImplementedException();
        }

        private static void PrimzahlenComponentWithDelegateEvents_SucheAbgeschlossenDelegate(string message)
        {
            Console.WriteLine(message);
        }

        private static void PrimzahlenComponentWithDelegateEvents_PrimzahlGefundenDelegate(int primzahl)
        {
            Console.WriteLine("Primzahl gefunden: " + primzahl);
        }
        #endregion
    }

    #region Componenten-Hersteller 
    public delegate void PrimzahlGefundenEventDelegate(int primzahl);
    public delegate void SucheAbgeschlossenEventDelegate(string message);

    public class PrimzahlenComponentWithDelegateEvents
    {
        //Diese Event-Delegates KÖNNEN (nicht muss) vom Kunden verwendet werden, damit dieser erfährt, was in dieser Komponente passiert.
        public event PrimzahlGefundenEventDelegate PrimzahlGefundenDelegate;
        public event SucheAbgeschlossenEventDelegate SucheAbgeschlossenDelegate;

        public void SearchPrimzahlen(int start, int end)
        {
            for (int number = start; number <= end; number++)
            {
                if (IsPrimzahl(number))
                {

                    //Wird das PrimzahlGefundenDelegate konsumiert (wenn ja, steckt hier eine Adresse drine und das Delegate ist NICHT null)
                    OnPrimzahlenGefunden(number);
                }
            }

            OnSucheAbgeschlossen("Sind fertig");
        }

        private void OnPrimzahlenGefunden(int primzahl)
        {
            if (PrimzahlGefundenDelegate != null)
            {
                //Invoke wird hier explizit aufgerufen, damit wir ein Callback ermöglichen
                PrimzahlGefundenDelegate.Invoke(primzahl);
            }
        }

        private void OnSucheAbgeschlossen(string msg)
        {
            //Kommunizieren nach draußen, bzw rufen den gemerkten Funktionzeiger (Methodeneinstig) auf. 
           SucheAbgeschlossenDelegate?.Invoke(msg);
        }

        private bool IsPrimzahl(int number)
        {
            if (number < 2) return false;
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0) return false;
            }
            return true;
        }
    }
    #endregion


    public class PrimzahlGeneratorWithEventHandler
    {
        public event EventHandler<int> GenericPercentValueChanged;
        public event EventHandler<string> GenericProcessCompleted;

        public void StartProcess()
        {
            for (int i = 0; i <= 100; i++)
            {

                //Wird dieses Event verwenden? 
                if (GenericPercentValueChanged != null)
                {
                    GenericPercentValueChanged(this, i);
                }
            }

            if (GenericProcessCompleted != null)
                GenericProcessCompleted(this, "Sind fertig");
        }
    }

}
