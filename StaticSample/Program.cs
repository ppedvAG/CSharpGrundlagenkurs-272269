namespace StaticSample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            GarbargeCollectorSample();

            Vehicle.ShowInstanceCounter(); //Kann sein, dass hier das VehicleCounter bei 0 steht.


            //Wir zwingen unseren GarbargeCollector dass er aufräumt (Alle Objekte die in GarbargeCollectorSample()-Methode verwendet wurden) 
            GC.Collect();
            GC.WaitForPendingFinalizers();


            Vehicle.ShowInstanceCounter();

        }

        static void GarbargeCollectorSample()
        {
            //vehicle, vehicle1, vehicle2, vehicle3 ist nur in dieser Methode gültig. Beim Verlassen der Methode werden die Objekt im 
            //Arbeisspeicher aufgeräumt:

            //vehicle ist unsere Instant 
            Vehicle vehicle = new Vehicle();

            //Es ist eine einfache Hilfsmethode, die am Datentyp Vehicle hängt.
            double mph = Vehicle.MphToKmh(vehicle.AktGeschwindidkeit);

            Vehicle vehicle1 = new Vehicle();
            Vehicle vehicle2 = new Vehicle();
            Vehicle vehicle3 = new Vehicle();


            Vehicle.ShowInstanceCounter();
        } //Ab hier werden die Instanzen nicht mehr benötigt und das bekommt der GarbageCollector mit. 
    }
}
