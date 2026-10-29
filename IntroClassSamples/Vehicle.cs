using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroClassSamples
{
    //Als Klasse bezeichnen wir den Bauplan für ein Objekt
    public class Vehicle
    {
        //Eigenschaften (Member-Variable) 
        //Eigenschaften beschreiben eine Klasse (Objekt) mit Variablen. 
        public string Brand {  get; set; }
        public string Model { get; set;  }
        public int ConstructionYear { get; set; }

        public string Farbe {  get; set; }

        public int MaxGeschwindigkeit { get; set; }
        public int AktGeschwindidkeit { get; set; }


        //Alternativ zu Default-Werten via Konstruktor, kann man auch einer Property einen Default Wert mitgeben. 
        public bool MotorStatus { get; set; } = false;



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
            :this(brand, model, constructionYear, farbe) 
        {
            MaxGeschwindigkeit = maxGeschwindigkeit;
        }





        //Kopierkonstruktor: Wird verwendet, wenn ich ein neues Objekt erstellen möchte, dass die Werte von einem anderen Vehicle-Objekt verwendet, ABER unabhängig ist.
        public Vehicle (Vehicle otherVehicle)
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

        public string ShowStatus()
        {

            string ausgabe = string.Empty;

            //Motor ist eingeschaltet
            if (MotorStatus)
            {
                if (AktGeschwindidkeit > 0)
                {
                    ausgabe = $"{Brand} {Model} fährt aktuell mit einer Geschwindkeit von {AktGeschwindidkeit} und kann maximal {MaxGeschwindigkeit} fahren";
                }
                else
                {
                    //0 Kmh mit Motor an
                    ausgabe = $"{Brand} {Model} steht aktuell an einer Ampel/Bahnübergang";
                }
            }
            else
            {
                ausgabe = $"{Brand} {Model} parkt";
            }

            return ausgabe;
        }
    }
}
