using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Vererbung
{
    //Als Klasse bezeichnen wir den Bauplan für ein Objekt
    public class Vehicle
    {

        //Eigenschaften (Member-Variable) 
        //Eigenschaften beschreiben eine Klasse (Objekt) mit Variablen. 
        public string Brand { get; set; }
        public string Model { get; set; }
        public int ConstructionYear { get; set; }

        public string Farbe { get; set; }

        public int MaxGeschwindigkeit { get; set; }
        public int AktGeschwindidkeit { get; set; }


        //Alternativ zu Default-Werten via Konstruktor, kann man auch einer Property einen Default Wert mitgeben. 
        public bool MotorStatus { get; set; } = false;




        //Statische Variablen, sind NICHT Instanzbezogen, sondern hängen am Datentyp (Programmweit gibt es nur eine Varible)
        //Alle Instanzen teilen sich die statische Variable AnzahlVehicleInstanzen. 
        private static int AnzahlVehicleInstanzen = 0;



        //Konstruktoren: Der Konstruktor gibt uns die Möglich, dass das Objekt zum Start seiner Laufzeit, Initialwerte erhält.

        //Default-Konstrukor gibt Default-Werte
        public Vehicle()
        {
            //Hier könnten wir Defaultwerte hinterlegen 
            //Nicht jede Klasse benötigt einen Default-Konstruktor. 
            //Brand = "Citrön";
            //Model = "Ente";
            //ConstructionYear = 1985;
            //Farbe = "metallic";
            AktGeschwindidkeit = 0;
            MotorStatus = false;
            AnzahlVehicleInstanzen++;
        }


        //Wenn ein Objekt zerstört wird, wird der Dekonstruktor aufgerufen. 
        ~Vehicle()
        {
            AnzahlVehicleInstanzen--;
        }


        //Wertekonstruktor: Geben explizit die Werte an, die unser Vehicle beinhalten soll 
        public Vehicle(string brand, string model, int constructionYear)
            : this()
        {
            Brand = brand;
            Model = model;
            ConstructionYear = constructionYear;
        }

        //Werte-Konstruktor mit Verkettung
        public Vehicle(string brand, string model, int constructionYear, string farbe)
            : this(brand, model, constructionYear) //Hier rufen wir Vehicle(string brand, string model, int constructionYear) auf 
        {
            Farbe = farbe;
        }

        public Vehicle(string brand, string model, int constructionYear, string farbe, int maxGeschwindigkeit)
            : this(brand, model, constructionYear, farbe)
        {
            MaxGeschwindigkeit = maxGeschwindigkeit;
        }





        //Kopierkonstruktor: Wird verwendet, wenn ich ein neues Objekt erstellen möchte, dass die Werte von einem anderen Vehicle-Objekt verwendet, ABER unabhängig ist.
        public Vehicle(Vehicle otherVehicle)
        {
            Brand = otherVehicle.Brand;
            Model = otherVehicle.Model;
            ConstructionYear = otherVehicle.ConstructionYear;
            Farbe = otherVehicle.Farbe;
        }


        public void StarteMotor() => MotorStatus = true;


        public void StoppeMotor()
        {
            if (AktGeschwindidkeit > 0)
            {
                Console.WriteLine("Auto muss vorher stehen (Geschwindigkeit 0) um den Motor auszuschalten");
                return;
            }

            MotorStatus = false;
        }


        //Methoden in einer Klasse, beschreiben den Funktionsumfang (Was ein Vehicle alles machen kann) 
        public void Hupen()
        {
            Console.WriteLine($"{Brand} - {Model} hupt!");
        }


        /// <summary>
        /// Beschleunigung des Fahrzeuges
        /// </summary>
        /// <param name="offSetSpeed">zusätzliche Geschwindigkeitsanstieg</param>

        public void Beschleunigen(int offSetSpeed)
        {
            //Parametervalidierung

            //Wenn der Motor ausgeschaltet ist? 
            if (!MotorStatus)
            {
                Console.WriteLine("Erst mit eingeschalten Motor kann man Beschleunigen");
                return;
            }

            //Wenn der Beschleunigunsparamter kleiner als O ist
            if (offSetSpeed <= 0)
            {
                //Variante 1: Einfache Textausgabe
                Console.WriteLine("offSetSpeed muss einen positiven Wert beinhalten");

                //Variante 2: Eine richtige Fehlermeldung generieren 
                //throw new ArgumentException("offSetSpeed muss einen positiven Wert beinhalten");
            }

            //Müssen überprüfen ob aktuelleGeschwindikeit + offSetSpeed nicht die MaxGeschwindkeit überschreiten 
            if ((AktGeschwindidkeit + offSetSpeed) > MaxGeschwindigkeit)
            {
                AktGeschwindidkeit = MaxGeschwindigkeit; //Geht nur bis Maximale Geschwindikeit
            }
            else
            {
                AktGeschwindidkeit = AktGeschwindidkeit + offSetSpeed;
                //AktGeschwindidkeit += offSetSpeed; //Normale Beschleunigung 
            }
        }

        public void Bremsen(int downsetSpeed)
        {
            if (!MotorStatus)
            {
                Console.WriteLine("Bremsen geht nur, wenn der Motor eingeschaltet ist");
                return;
            }


            //Wenn nach dem Bremsen unterhalb von 0, dann wird die AktuelleGeschwindigkeit auf 0 gesetzt

            if ((AktGeschwindidkeit - downsetSpeed) < 0)
            {
                AktGeschwindidkeit = 0;
            }
            else
            {
                AktGeschwindidkeit = AktGeschwindidkeit - downsetSpeed;
                //AktGeschwindidkeit -= downsetSpeed;
            }

        }

        public virtual string ShowStatus()
        {

            string ausgabe = string.Empty;

            //Motor ist eingeschaltet
            if (MotorStatus)
            {
                if (AktGeschwindidkeit > 0)
                {
                    ausgabe = $"{Brand} {Model} bewegt sich aktuell mit einer Geschwindkeit von {AktGeschwindidkeit} und kann maximal {MaxGeschwindigkeit} sich fortbewegen";
                }
                else
                {
                    //0 Kmh mit Motor an
                    ausgabe = $"{Brand} {Model} steht aktuell mit angeschalteten Motor";
                }
            }
            else
            {
                ausgabe = $"{Brand} {Model} parkt";
            }

            return ausgabe;
        }


        public override string ToString()
        {
            string ausgabe = string.Empty;

            //Motor ist eingeschaltet
            if (MotorStatus)
            {
                if (AktGeschwindidkeit > 0)
                {
                    ausgabe = $"{Brand} {Model} bewegt sich aktuell mit einer Geschwindkeit von {AktGeschwindidkeit} und kann maximal {MaxGeschwindigkeit} sich fortbewegen";
                }
                else
                {
                    //0 Kmh mit Motor an
                    ausgabe = $"{Brand} {Model} steht aktuell mit angeschalteten Motor";
                }
            }
            else
            {
                ausgabe = $"{Brand} {Model} parkt";
            }

            return ausgabe;
        }


        //Statische Methonden werden als Hilfsmethoden verwenden.


        /// <summary>
        /// Wandelt Kilometer pro Stunde in Meilen pro Stunde um.
        /// </summary>
        public static double KmhToMph(double kmh)
        {
            return kmh * 0.621371;
        }

        /// <summary>
        /// Wandelt Meilen pro Stunde in Kilometer pro Stunde um.
        /// </summary>
        public static double MphToKmh(double mph)
        {
            return mph / 0.621371;
        }

        public static void ShowInstanceCounter()
        {
            Console.WriteLine("Es gibt aktuell " + AnzahlVehicleInstanzen + " Instanzen");
        }
    }



    //Plan vererbt von Vehicle
    public class Plain : Vehicle
    {
        public double Spannweite { get; set; }
        public int MaximaleFlughoehe {  get; set; }
        public int AktuelleFlueghoehe { get; set; }

        public Plain(string brand, string model, int constructionYear, string farbe, int maxGeschwindigkeit, double spannweite, int maximaleFlughohe)
            :base(brand, model, constructionYear, farbe, maxGeschwindigkeit)
        {
            Spannweite = spannweite;
            MaximaleFlughoehe = maximaleFlughohe;
            AktuelleFlueghoehe = 0;
        }

        public void Aufsteigen (int offSetMeter)
        {
            //...
            AktuelleFlueghoehe+= offSetMeter;
        }

        public void Sinkflug (int offSetMeter)
        {
            //...

            AktuelleFlueghoehe -= offSetMeter;
        }

        //public override string ShowStatus()
        //{
        //    string ausgabe = string.Empty;
        //    if (MotorStatus)
        //    {
        //        if (AktGeschwindidkeit == 0)
        //        {
        //            ausgabe = $"{Brand} {Model} steht am Hangar und der Motor ist eingeschaltet";
        //        }
        //        else if (AktuelleFlueghoehe == 0)
        //        {
        //            //AktGeschwindikeit ist vorhanden, aber ist noch auf dem Boden
        //            ausgabe = $"{Brand} {Model} befindet sich auf der Landebahn oder fährt zur Landebahn";
        //        }
        //        else if (AktuelleFlueghoehe > 0 && AktGeschwindidkeit > 0)
        //        {
        //            ausgabe = $"{Brand} {Model} fliegt mit {AktGeschwindidkeit} auf {AktuelleFlueghoehe} Meter in der Luft";
        //        }
        //    }
        //    else
        //    {
        //        ausgabe = $"{Brand} {Model} steht am Hangar und der Motor ist ausgeschaltet";
        //    }

        //    return ausgabe;
        //}

    }

}
