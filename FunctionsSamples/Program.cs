namespace FunctionsSamples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Methoden können überladen werden, wichtig ist, dass die Parameter-Signatur jeweils eine andere ist, damit der Kompilier die jeweiligen Methoden unterscheiden kann
            Addiere(4, 5); //void Addiere(int a,int b)
            Addiere(4.5, 4.4); // void Addiere(double a, double b)
            Addiere(5, 6, 7); // void Addiere(int a, int b , int c)

            //Optionale Parameter
            Greeter("Otto Walkes");
            Greeter(); //Hier wird der hinterlegte Wert "Guest" verwendet. 


            GreeterB("PPEDV", "Bill Gates");
            GreeterB("PPEDV");


            AddiereAlle(1,2, 3);
            AddiereAlle(1, 2, 3, 4, 5, 6, 7, 8);

            int[] zahlenArray = { 2, 4, 6, 8 };
            AddiereAlle(zahlenArray); //Können alternativ auch ein Arry Direkt übergeben


            Fakultät(5); //5 * 4 * 3 * 2 * 1
        }


        //Überladen von Methoden 
        static void Addiere(int a,int b)
        {
            Console.WriteLine($"Ergebnis. {a+b}");
        }

        static void Addiere(double a, double b)
        {
            Console.WriteLine($"Ergebnis. {a + b}");
        }

        static void Addiere(int a, int b , int c)
        {
          
            Console.WriteLine($"Ergebnis. {a + b + c}");
        }

       
        //Optionaler Parameter
        static void Greeter(string username = "Guest")
        {
            Console.WriteLine("Hello " + username);
        }

        static void GreeterB(string company, string username = "Guest")
        {
            Console.WriteLine(company + " " + username);
        }

        //Rekrussive Methoden rufen sich selber immer wieder auf, bis ein gewisser Fall erfüllt wird.
        static void Countdown(int zahl)
        {
            Console.WriteLine(zahl);

            if (zahl == 0)
                return; // Abbruchbedingung

            Countdown(zahl - 1);
        }

        static int Fakultät(int n)
        {
            if (n <= 1)
                return 1;

            return n * Fakultät(n - 1);
        }


        //Params 

        static int AddiereAlle(params int[] zahlen)
        {
            int summe = 0;

            //Gehen Array mit unbekannter Length durch 
            foreach (int i in zahlen)
            {
                summe += i; //Addieren alles
            }

            return summe;
        }
    }
}
