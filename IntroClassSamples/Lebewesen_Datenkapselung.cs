using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Text;

namespace IntroClassSamples
{
  
    
    //Anti-Beispiel für Datenkapselung

    //Durch die Puplic Variablen, ist es möglich, dass das Objekt falsche Werte behinhalten kann (Was zu Fehler führen kann) 
    public class LebewesenAntiBeispiel
    {
        public DateTime birthday;
        public double weight;
        public double height;



        public void Communication()
        {

        }
    }



    //Datenkapselung bedeutet, dass die Variablen alle Private sind.
    //Zuweisung erfolgen durch Get- und Set-Methoden
    public class LebewesenGetSetterMethoden
    {
        //Die Private Variablen gelten überall in meiner Klasse

        private DateTime birthday;
        private double weight;
        private double height;

        //Get und Set-Methoden für das kontrollierte zuweisen von Werten oder herauslesen
        //Alter Stil, der in Java und C++ vorhanden ist

        public void SetHeight(double newHeight)
        {
            //Validierung wird eingebaut
            //NewHeight darf keinen Negativen wert beinhalten
            if (newHeight < 0)
            {
                Console.WriteLine("Die Hohe eines Lebewesen muss einen positiven Wert aufweisen");

                //vorzeitig verlassen wir die Methode
                return; //Wir verlassen die Methode
            }


            //Zuweisung des neuen Wertes via newHeight
            height = newHeight;
        }

        public double GetHeight()
        {
            return height;
        }


        public void SetWeight(double weight)
        {
            if (weight > 0)
            {
                //this.weight ist die private double weight - Variable
                //Das andere 'weight' ist der Parameter meiner Funktion 
                this.weight = weight;
            } 
            else
            {
                Console.WriteLine("Gewicht muss ein positiver Wert aufweisen");
            }
        }

        public double GetWeight()
        {
            return this.weight;
        }


        public void SetBirthday(DateTime newBirthday)
        {
            //Geburtsdatum darf nicht in der Zukunft liegen

            if (DateTime.Now.Ticks > newBirthday.Ticks)
            {
                this.birthday = newBirthday;
            }
            else
            {
                Console.WriteLine("Geburtstadum darf nicht in der Zukunft liegen");
            }
        }


        //Alte schreibweise 
        public DateTime GetBirthday() {
            return birthday;
        }


        //Neue Schreibweise
        public DateTime GetBirthdayShort => birthday;



        public void DescripeMe() => Console.WriteLine($"Höhe: {height}\nGewicht: {weight}\nGeburtsdatum:{birthday.ToShortDateString()} ");


    }





    public class LebewesenMitProperties
    {
        private DateTime birthday;
        private double weight;
        private double height;


        //Properties werden immer Groß geschrieben
        public double Height
        {
            set
            {
                //Hier können wir Validierung ermöglichen
                if (value < 0)
                {
                    Console.WriteLine("Die Höhe muss ein positiver Wert beinhalten");
                    return; 
                }


                height = value;
            }

            get
            {
                return height;
            }
        }
    }


    //Datenkapselung via Auto-Properties

    public class LebewesenMitAutoProperties
    {
        //Eine Auto-Property legt beim Kompilieren im Hintergrund: private Variablen an und verwendet diese.
        //Auto-Properties könnnen erstmal keine Valdierung. 
        //Wenn eine Auto-Property Validierung benötigt, dann erweitern wir nur die Property

        private double weight;
        
        
        public double Height { get; set; }

        public double Weight 
        { 
            get
            {
                return weight;
            }

            set 
            {
                if (value < 0)
                {
                    Console.WriteLine("Gewicht muss Positiv sein");
                }

                weight = value;
            }
        }

        public DateTime Birthday { get; set; }

        public void DescripeMe() => Console.WriteLine($"Höhe: {Height}\nGewicht: {Weight}\nGeburtsdatum:{Birthday.ToShortDateString()} ");

    }











}
