namespace OOP_Vererbung
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vehicle vehicle = new Vehicle("BMW", "3er", 2011, "rot", 200);
            vehicle.StarteMotor();
            vehicle.Beschleunigen(100);

            Plain lufthansaMaschine = new Plain("Airbus", "A320", 2020, "blau", 1200, 30, 15000);
            lufthansaMaschine.StarteMotor();
            lufthansaMaschine.Beschleunigen(100);
            lufthansaMaschine.Aufsteigen(5000);
            lufthansaMaschine.Sinkflug(2000);



            Console.WriteLine("Show-Status bei einem Vehicle");
            Console.WriteLine(vehicle.ShowStatus());


            Console.WriteLine("Show-Status bei einem Plain");
            Console.WriteLine(lufthansaMaschine.ShowStatus());


            EmptyClass emptyClass = new EmptyClass();



            Console.WriteLine("ToString() Sample:");
            Console.WriteLine(vehicle.ToString());
            Console.WriteLine(lufthansaMaschine.ToString());




        }
    }

    public class EmptyClass
    {

    }
}
