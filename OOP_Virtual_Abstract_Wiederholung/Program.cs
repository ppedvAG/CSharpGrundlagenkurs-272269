namespace OOP_Virtual_Abstract_Wiederholung
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Säugetier> tiere = new List<Säugetier>();
            tiere.Add(new Katze());
            tiere.Add(new Hund());
            tiere.Add(new Stubentiger());


            foreach (Säugetier aktuellesTier in tiere)
            {
                aktuellesTier.Communication();
            }

            //ALLE Inszanziierungen von stubentiger1 bis stubentiger 4 sind alles Stubentiger 

            //Warum? Weil Alle den Stubentiger Konstruktor aufrufen
            Stubentiger stubentiger1 = new Stubentiger();
            stubentiger1.Width = 100;
            stubentiger1.Height = 100;
            stubentiger1.Bezeichnung = "Garfield 1";
            stubentiger1.IstFleichfresser = true;
            stubentiger1.LebtInFreiheit = false;
            stubentiger1.MagLassagne = true; //MagLassagne ist auf Stubentiger-Klasse


            Katze stubentiger2 = new Stubentiger();
            stubentiger2.Height = 100;
            stubentiger2.Width = 100;
            stubentiger2.Height = 100;
            stubentiger2.Bezeichnung = "Garfield2";
            stubentiger2.IstFleichfresser = true;
            stubentiger2.LebtInFreiheit = false;
            

            //Basis (Zugänglich sind alle Methoden von Katze bis zur Basisklassen
            stubentiger2.MagLassagne = true;

            Stubentiger gecasteterStubentieger = (Stubentiger)stubentiger2;
            gecasteterStubentieger.MagLassagne = true;


            Säugetier stubentiger3 = new Stubentiger();
            stubentiger3.Height = 100;
            stubentiger3.Width = 100;
            stubentiger3.Height = 100;
            stubentiger3.Bezeichnung = "Garfield2";
            stubentiger3.IstFleichfresser = true;

            //Basis (Zugänglich sind alle Methoden von Säugetier bis zur Basisklassen
            stubentiger3.LebtInFreiheit = false;
            stubentiger3.MagLassagne = true;


            Lebewesen stubentiger4 = new Stubentiger();

            stubentiger4.Height = 100;
            stubentiger4.Width = 100;
            stubentiger4.Height = 100;
            stubentiger4.Bezeichnung = "Garfield2";


            stubentiger4.IstFleichfresser = true;
            //Basis (Zugänglich sind alle Methoden von Säugetier bis zur Basisklassen
            stubentiger4.LebtInFreiheit = false;
            stubentiger4.MagLassagne = true;









            object lebewesen5 = new Stubentiger();
            lebewesen5.Height = 100;
            lebewesen5.Width = 100;
            lebewesen5.Height = 100;
            lebewesen5.Bezeichnung = "Garfield2";


            lebewesen5.IstFleichfresser = true;
            //Basis (Zugänglich sind alle Methoden von Säugetier bis zur Basisklassen
            lebewesen5.LebtInFreiheit = false;
            lebewesen5.MagLassagne = true;




            List<Katze> katzen = new List<Katze>();
            katzen.Add(new Puma());
            katzen.Add(new Leopard());
            katzen.Add(new Stubentiger());
            katzen.Add(stubentiger2);
            katzen.Add(stubentiger1); //Aber auch hier wird noch angeboten, was die Katzen-Klasse anbietet. 

            foreach (Katze akteullesKatzentier in katzen)
            {
                akteullesKatzentier.KannBalancieren();
            }
        }
    }
}
