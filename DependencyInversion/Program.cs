namespace DependencyInversion
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Wir wird die Logik zusammengebracht (getesteter Code) 
            
            IEngine engine = new Engine();

            ICar car = new Car(engine);

            ICarService service = new CarService();
            service.RepairCar(car);



            //Testbarkeit
            IEngine mockEngine = new MockEngine();

            //Jetzt kann ich mit einem Dummy-Objekt meine Klasse testen.
            ICar myCar = new Car(mockEngine);

            //Wenn Klasse Engine fertig ist und keine Fehler hat, kann ich das orginal verwenden
            myCar = new Car(engine);
        }
    }

    #region FESTE KOPPLUNG (Bad Sample)
    //Programmier A: 
    //Dauer 3 Tage


    //Entwicklungstagebuch: Tag 1 bis Tag 3 in Aktion 
    public class BadEngine
    {
        public int PS {  get; set; }

        public void StarteMotor()
        {
           
            Console.WriteLine("Aktiviere Zündkerzen");
            Console.WriteLine("Starte Motor");

           // throw new Exception("Ein Bug ist hier passiert");
        }
    }


    //Programmierer B:
    //Dauer 3 Tage
    //Entwicklungstagebuch: Tag 2 bis Tag 4/5 in Aktion 
    public class BadCar
    {
        public int ReifenAnzahl {  get; set; }


        //Hier ist eine FEST KOPPLUNG -> BadCar-Klasse kennt die BadEngine Klasse 
        private BadEngine engine;

        public BadCar(BadEngine engine)
        {
            this.engine = engine;
        }


        public void StartRoutine()
        {
            //Batterie Vorhanden
            //Greife auf Batterie zu

            engine.StarteMotor(); //Hier fällt der Bug Programmer B die Füsse

            //starte ABS Sytem 
        }


        public void Bremsen()
        {
            Console.WriteLine("Auto bremst");
        }
    }



    //Programmierer C:
    //Dauer 3 Tage

    //Entwicklungstagebuch: Tag 4/5 bis Tag 7/8 in Aktion 
    public class BadCarService
    {


        //FESTE KOPPLUNG BadCar Paramter. 
        public void TesteCar(BadCar car)
        {
            car.StartRoutine(); //Hier fällt der Bug Programmer C die Füsse
        }

        public void RepairCar(BadCar car)
        {
            //Reifen werden wieder vervollständigt
            car.ReifenAnzahl = 4;
        }
    }

    #endregion

    #region Loose Kopplung

    //Contract First (Erstelle zuerst Interface) 
    public interface IEngine
    {
        void StarteMotor();
    }

    public interface ICar
    {
        void StartRoutine(); 
    }

    public interface ICarService
    {
        void TesteCar(ICar car);

        void RepairCar(ICar car);
    }


    //Programmier A: 
    //Dauer 3 Tage


    //Entwicklungstagebuch: Tag 1 bis Tag 3 in Aktion 
    public class Engine : IEngine
    {
        public int PS { get; set; }

        public void StarteMotor()
        {

            Console.WriteLine("Aktiviere Zündkerzen");
            Console.WriteLine("Starte Motor");

            throw new Exception("Ein Bug ist hier passiert");
        }
    }

    //Programmierer B:
    //Dauer 3 Tage

    //Entwicklungstagebuch: Tag 1 bis 3

    public class Car : ICar
    {
        private IEngine engine;

        public Car(IEngine engine)
        {
            this.engine = engine;
        }

        public void StartRoutine()
        {
            engine.StarteMotor(); //Programmierer B erhält hier ein Bug, weil er mit dem Interface arbeiten und NICHT mit der Klasse Engine
        }
    }

    public class MockEngine : IEngine
    {
        public void StarteMotor()
        {
            Console.WriteLine("starten funktioniert simulativ");
        }
    }





    //Programmierer C:
    //Dauer 3 Tage

    //Entwicklungstagebuch: Tag 1 bis Tag 3

    public class CarService : ICarService
    {
        public void RepairCar(ICar car)
        {
            //Repariere Auto
        }

        public void TesteCar(ICar car)
        {
            car.StartRoutine();
        }
    }
    #endregion
}
