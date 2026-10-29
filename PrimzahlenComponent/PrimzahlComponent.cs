namespace PrimzahlenComponent
{

    //PrimzahlComponent
    public class PrimzahlComponent
    {
        public EventHandler<int> FoundPrimzahlEvent;
        public EventHandler<string> PrimzahlSearchProcessFinish;



        public void SearchPrimzahl(int until)
        {
            for (int i = 1; i <= until; i++)
            {
                if (IstPrimzahl(i))
                {
                    FoundPrimzahlEvent?.Invoke(this, i);
                }
                else
                {
                    if (i > 100)
                    {
                        //Generieren wir ein Fehler

                        //Wenn ein Fehler i

                        throw new EigenePrimzahlException("Fehler in der Primzahlensuche");
                    }
                }
            }

            PrimzahlSearchProcessFinish?.Invoke(this, "sind fertig");
        }

        public bool IstPrimzahl(int zahl)
        {
            if (zahl < 2)
            {
                return false;
            }

            for (int teiler = 2; teiler * teiler <= zahl; teiler++)
            {
                if (zahl % teiler == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }


    public class EigenePrimzahlException : Exception
    {
        public EigenePrimzahlException(string message)
            :base(message)
        {
            
        }
    }
}
