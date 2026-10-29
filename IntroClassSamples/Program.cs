namespace IntroClassSamples
{
    //Regeln für Klassen 
    // - Eine Klasse muss immer in EINER Datei stehen. 
    internal class Program
    {
        static void Main(string[] args)
        {
            //Vehicle vehicle1 (Deklaration)
            Vehicle vehicle1;

            //Hier bauen wir das mit 'new Vehicle()' zu einem Objet. 
            vehicle1 = new Vehicle();
            vehicle1.Hupen();


            Vehicle vehicle2 = new Vehicle();

            //Verkürzte Schreibvariante
            Vehicle vehicle3 = new();

            //Var Datentyp, sage ich, dass zur Laufzeit mit der Datentyp aufgelöst wird 
            var vehicle4 = new Vehicle();



            //Datenkapselung (Anti-Beispiel)
            LebewesenAntiBeispiel lebewesen = new LebewesenAntiBeispiel();

            lebewesen.weight = -5;
            lebewesen.height = -5;
            lebewesen.birthday = new DateTime(2030, 5, 4);




            LebewesenGetSetterMethoden lebewesenGetSetterMethoden = new LebewesenGetSetterMethoden();
            lebewesenGetSetterMethoden.SetHeight(-5);
            lebewesenGetSetterMethoden.SetHeight(7); //7 wird genommen
            lebewesenGetSetterMethoden.SetWeight(5);
            DateTime birthday = new DateTime(1983, 8, 23);
            lebewesenGetSetterMethoden.SetBirthday(birthday);
            //kann mit birthday auch hier noch weiter arbeiten.


            //Verkürzte Schreibweise für eine 1x Benutzung:
            //lebewesenGetSetterMethoden.SetBirthday(new DateTime(1983, 8, 23));

            lebewesenGetSetterMethoden.DescripeMe();






            //Erstellen des Objektes + Initalisierung 
            LebewesenMitProperties lebewesenMitProperties = new LebewesenMitProperties();

            //Update der Objekt-Werte (Kontrolliert) 
            lebewesenMitProperties.Height = 10;



            //Konstruktoren:

            //Default-Konstruktor
            Vehicle vehicle = new Vehicle();
            vehicle.Hupen();


            //Werte-Konstruktor

            Vehicle myVehicle = new Vehicle("VW", "Passat", 2020);
            myVehicle.Hupen();

            Vehicle myVehicle2 = new Vehicle("Porsche", "911", 2025);
            myVehicle2.Hupen();


            //Kopierkonstrutor:

            //Warum benötige ich einen Kopierkonstruktur
            Console.WriteLine("Kopierkonstruktor-Sample: Einstiegsbeispiel (nur mit Referenceübergabe) ");
            //Hier übergeben wir die Speicheradresse von myVehicle2 (Porsche) an myReferenceVehicle
            
            Vehicle myReferenceVehicle = myVehicle2;
            myReferenceVehicle.Hupen();

            myReferenceVehicle.Model = "924";


            myVehicle2.Hupen();
            myReferenceVehicle.Hupen();


            //Lösung: Kopierkonstrukor-Beispiel: 

            Console.WriteLine("Kopierkonstruktor-Sample: (mit Kopierkonstruktor) ");
            //Wir kopieren myVehicle2 an myCopyVehicle
            Vehicle myCopyVehicle = new Vehicle(myVehicle2);

            myCopyVehicle.Brand = "Audi";
            myCopyVehicle.Model = "Quatro";
            myCopyVehicle.ConstructionYear = 1998;

            myVehicle2.Hupen();
            myCopyVehicle.Hupen();




            Vehicle gta6Car = new Vehicle("Audi", "A4", 2011, "schwarz", 210);
            Console.WriteLine(gta6Car.ShowStatus());

            //Schalten den Motor ein
            gta6Car.StarteMotor();
            Console.WriteLine(gta6Car.ShowStatus());

            //Beschleunige
            gta6Car.Beschleunigen(100);
            Console.WriteLine(gta6Car.ShowStatus());

            //Beschleunige bis Maximal
            gta6Car.Beschleunigen(400);
            Console.WriteLine(gta6Car.ShowStatus());

            //Bremsen
            gta6Car.Bremsen(100); //110
            Console.WriteLine(gta6Car.ShowStatus());
            
            
            //Vollbremsung
            gta6Car.Bremsen(400);
            Console.WriteLine(gta6Car.ShowStatus());

            //Motor-Ausschalten
            gta6Car.StoppeMotor();
            Console.WriteLine(gta6Car.ShowStatus());
        }
    }

}
