namespace InterfaceSegerationPrincipe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }

    public interface IVehicle
    {
        void CanFly();
        void CanDrive();
        void CanSwim();
    }

    public class Vehicle : IVehicle
    {
        public void CanDrive()
        {
            Console.WriteLine("Kann fahren");
        }

        public void CanFly()
        {
            Console.WriteLine("Kann fliegen");
        }

        public void CanSwim()
        {
            Console.WriteLine("Kann schwimmen");
        }
    }

    public class BadAmphibischesVehicle : IVehicle
    {
        public void CanDrive()
        {
            Console.WriteLine("Kann fahren");
        }

        public void CanSwim()
        {
            Console.WriteLine("Kann schwimmen");
        }


        //Diese Methode geht nicht bei Amphibische Fahrzeuge und ist leer oder brint ein Fehler
        public void CanFly()
        {
            throw new NotSupportedException();
        }
    }

    public interface IDriveable
    {
        void CanDrive();
    }

    public interface ISwimable
    {
        void CanSwim();
    }

    public interface IFlyable
    {
        void CanFly();
    }


    public class AmphibischesVehicle : IDriveable, ISwimable
    {
        public void CanDrive()
        {
            Console.WriteLine("Kann fahren");
        }

        public void CanSwim()
        {
            Console.WriteLine("Kann schwimmen");
        }
    }
}
