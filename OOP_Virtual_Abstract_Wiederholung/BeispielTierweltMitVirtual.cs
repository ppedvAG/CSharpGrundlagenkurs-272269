using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Virtual_Abstract_Wiederholung
{
    public class Lebewesen
    {
        public double Height { get; set;  }
        public double Width { get; set; }

        public string Bezeichnung { get; set; }

        public virtual void Communication ()
        {
            Console.WriteLine("Das Lebewesen: Kommuniziert auf seiner Art");
        }
    }

    public class Säugetier : Lebewesen
    {
        public bool HatFell { get; set; } = true;

        public bool IstFleichfresser { get; set; } = true;

        public override void Communication()
        {
            Console.WriteLine("Das Säuetier kommuniziert mit lauten");
        }


        public void KannKinderGebähren()
        {
            Console.WriteLine("Kann Babys gebähren");
        }
    }


    public class Hund : Säugetier
    {
        public bool ImRudel { get; set; } = false;
        public override void Communication()
        {
            Console.WriteLine("Der Hund bellt");
        }

        public void KannBriefträgerFangen()
        {
            Console.WriteLine("Spielt mit Briefträger");
        }
    }

    public class Katze : Säugetier
    {
        public bool LebtInFreiheit { get; set; } = true; 

        public override void Communication()
        {
            Console.WriteLine("Der Katze meowt");
        }

        public void KannBalancieren()
        {
            Console.WriteLine("Balanciert auf einen Baum");
        }
    }

    public class Stubentiger : Katze
    {
        public bool MagLassagne { get; set; } = true;


        public Stubentiger()
        {
            Console.WriteLine("Stubentiger wurde erstellt");
        }
        public override void Communication()
        {
            Console.WriteLine("Der Stubentiger schnarcht");
        }

        public void Verdauungsschlaf247()
        {
            Console.WriteLine("Schläft den ganzen Tag");
        }
    }

    public class Puma : Katze
    {

    }


    public class Leopard : Katze
    {

    }
}
