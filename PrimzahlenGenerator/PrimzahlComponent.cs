namespace PrimzahlenGenerator
{

    public delegate void FoundPrimzahlCallback(int primzahl);
    public delegate void FinishPrimzahlSucheCallback(string msg);

    public class PrimzahlComponent
    {
        public void SearchPrimzahlen(int start, int end, FoundPrimzahlCallback foundPrimzahlCallback, FinishPrimzahlSucheCallback finishPrimzahlSucheCallback)
        {
            for (int number = start; number <= end; number++)
            {
                //Ist die Aktuelle number eine Primzahl?
                if (IsPrimzahl(number))
                {
                    //Wollen wir das direkt dem Programm mitteilen
                    foundPrimzahlCallback(number);
                }
            }
            finishPrimzahlSucheCallback("ich bin fertig mit der Suche");

            //Wenn wir fertig sind, wollen wir das dem Programm direkt mitteilen 
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
}
