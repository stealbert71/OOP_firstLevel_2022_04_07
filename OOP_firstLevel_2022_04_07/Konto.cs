using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_firstLevel_2022_04_07
{
    class Konto
    {
        // private Attribute anlegen
        private int kontoNr;
        private string besitzer;
        protected double kontostand;

        //Konstruktor mit Werten belegen
        public Konto()
        {
            this.kontoNr = 1;
            this.besitzer = "IT3";
            this.kontostand = 0.0;
        }

        //Schnittstellen nach außen der Klasse 
        //definieren get- bzw. set-Methoden
        public int KontoNr
        {
            get { return this.kontoNr; }
            set { this.kontoNr = value; }
        }

        public string Besitzer
        {
            get { return this.besitzer; }
            set { this.besitzer = value; }
        }

        public double Kontostand
        {
            get { return this.kontostand; }
            set { this.kontostand = value; }
        }

    }
}
