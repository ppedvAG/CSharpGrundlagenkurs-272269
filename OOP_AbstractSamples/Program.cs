namespace OOP_AbstractSamples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Geoform geoform = new Geoform(); wird ein Fehler anzeigen. 

            //Beispiel A
            Geoform[] geoforms = { new Rechteck(10, 2), new Kreis(4), new Triangle(4, 6.7) };

            double gesamtFlaeche = 0;
            foreach (Geoform geoform in geoforms)
            {
                gesamtFlaeche += geoform.CalculateArea();
            }



            //Beispiel B
            List<Geoform> geoformen = new List<Geoform>();

            Kreis kreis = new Kreis(5);
            Console.WriteLine(kreis.CalculateArea());


            Rechteck rechteck = new(5, 4);
            Console.WriteLine(rechteck.CalculateArea());

            Triangle triangle = new Triangle(4, 12);
            Console.WriteLine(triangle.CalculateArea());


            geoformen.Add(kreis);
            geoformen.Add(rechteck);
            geoformen.Add(triangle);
            geoformen.Add(new Rechteck(3, 6));

            gesamtFlaeche = 0;
            foreach (Geoform geoform in geoformen)
            {
                gesamtFlaeche += geoform.CalculateArea();
            }
        }
    }

    #region Anti-Beispiel: Bad Geometrie Form
    public class BadGeometrieForm
    {
        //Ich möchte die Fläche für Kreis, Rechteck, Zylinder etc berrechnen.
        //Es ist schwer eine Basisform der Klasse zu erstellen. 

        //Schlechter Versuch 1:
        public int A { get; set; }
        public int B { get; set; }
        public double PI { get; set; } = 3.14159;
    }

    public class BadRechteck : BadGeometrieForm
    {
        public double GetArea()
        {
            return A * B;
        }
    }
    #endregion


    //Wenn eine Methode abstrakt wird, DANN MUSS die Klasse auch als abstrakt markiert werden
    //Von eine Abstrakten Methoden, kann man keine Instanz bauen
    public abstract class Geoform
    {
        //CalculateArea kann keine richtige implementierung an dieser Stelle vorweisen, daher sagen wir, dass erst die vererbte Klasse, eine Implemntierung liefern muss.
        public abstract double CalculateArea();
    }



    //In der Vererbten Klasse MUSS ich die Methode CalculateArea ausimplemtieren.
    public class Rechteck : Geoform
    {
        public double A { get; set; }

        public double B { get; set; }


        public Rechteck(int a, int b)
        {
            A = a;
            B = b;
        }

        //MUSS-Implementierung
        public override double CalculateArea()
        {
            return A * B;
        }
    }


    public class Kreis : Geoform
    {
        public double Radius { get; set; }
        public Kreis(double radius)
        {
            Radius = radius;
        }

        public override double CalculateArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
    }

    public class Triangle : Geoform
    {
        public double Base { get; set; }
        public double Height { get; set; }
        public Triangle(double basis, double height)
        {
            Base = basis;
            Height = height;
        }
        public override double CalculateArea()
        {
            return 0.5 * Base * Height;
        }
    }
}
