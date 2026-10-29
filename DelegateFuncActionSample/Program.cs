namespace DelegateFuncActionSample
{

    //Das Delegate ist ein Datentyp und kann sich die Adresse einer Methode merken und später aufrufen. 
  

    public delegate double CalculationDelegate(double a, double b);
    public delegate double AdditionDelegateWithThreeParameter(double a, double b, double c);

    internal class Program
    {

        public delegate double AdditionDelegate(double a, double b);
        static void Main(string[] args)
        {
            #region Delegates (Basis-Wissen)
            AdditionDelegate additionDelegate = new AdditionDelegate(Add); //Hier übergebe ich die Adresse der Methode Add an das Delegate
            double erg = additionDelegate(10, 20);

            AdditionDelegateWithThreeParameter additionWith3Params = new AdditionDelegateWithThreeParameter(Add);
            erg = additionWith3Params(12, 34, 2);


            //Es gibt noch eine weitere Möglichkeit einer Methode an ein Delegate zu hängen 
            CalculationDelegate multiCalcDelegate = new CalculationDelegate(Add); //Gebe mir die Adresse von Add-Methode

            //Wir hängen via += Operator eine weitere Methode dran
            multiCalcDelegate += new CalculationDelegate(Subtract); //Füge zusätzlich (+=) die Methode von Subtract hinzu

            //Achtung Anfängerfehler: Bei Multi-Delegates (wird anders programmiert) 
            erg = multiCalcDelegate(10, 20); //Hier erhalten wir von der LETZTEN Methode das Ergebnis

            double result = 0;


            //Mit GetInvocationList und DynamicInvoke können wir multiple Delegate nacheinander korrekt ausführen!!!! 
            foreach (Delegate currentDelegateWithMethode in multiCalcDelegate.GetInvocationList())
            {
                double randomZahl = new Random().Next(1, 100);

                result = Convert.ToDouble(currentDelegateWithMethode.DynamicInvoke(result, randomZahl));
            }
            Console.WriteLine(result);

            Program.AdditionDelegate additionsDelegate123 = new Program.AdditionDelegate(Add);
            #endregion


            #region Action (.NET 3.0)
            //Action kann nur mit Methoden zusammenarbeiten, die ein 'void' als Rückgabetyp haben

            Action<string,int> outputActionDelegate = new Action<string,int>(LogText);
            outputActionDelegate("Hallo Welt", 3);

            #endregion

            #region Func
            //Bei Func ist der letzte Datentyp der Rückgabe-Typ von der Methode
            Func<double, double, double> calcFuncDelegate = new Func<double, double, double>(Add);
            erg = calcFuncDelegate(23, 2.5); //25.5
            #endregion




        }


        static double Add(double a, double b)
        {
            return a + b;
        }

        static double Subtract(double a, double b)
        {
            return a - b;
        }

        static double Add(double a, double b, double c)
        {
            return a + b;
        }

        static void LogText(string msg, int logLevel)
        {
            Console.WriteLine($"LogLevel: {logLevel} - Message: {msg}");
        }
        static void DebugText(string msg, int logLevel)
        {
            Console.WriteLine($"LogLevel: {logLevel} - Message: {msg}");
        }
    }
}
