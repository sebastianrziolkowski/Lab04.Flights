using System;
using System.Collections.Generic;
using System.Text;

namespace Dane.Model
{
    public abstract class Samolot
    {
        private Polozenie pozycja;
        private Miasto miastoWylot;
        private Miasto miastoCel;
        private string identyfikator;
        public double predkosc;


        public Samolot(string _identyfikator, Polozenie polozenie)
        {
            identyfikator = _identyfikator;
            pozycja = polozenie;

        }

        public Samolot(string _identyfikator, double predkosc)
        {
            identyfikator = _identyfikator;
            this.predkosc = predkosc;
            //pozycja = new Polozenie(new double(), new double());
           // miastoWylot = new Miasto();
            //miastoCel = new Miasto() ;
         }
        
        public Samolot(string _identyfikator, double predkosc, Miasto miastoWylotu)
        {
            identyfikator = _identyfikator;
            this.predkosc = predkosc;
            miastoWylot = miastoWylotu;
            pozycja = new Polozenie(miastoWylot.PolozenieM.X, miastoWylot.PolozenieM.Y);
           // miastoCel = new Miasto();

        }

        public string Identyfikator
        {
            set { identyfikator = value; }
            get { return identyfikator; }   
        }

        public Miasto GetMiastoWylot()
        {
            return miastoWylot;
        }

        public void SetMiastoWylot(Miasto _miasto)
        {
            miastoWylot = _miasto;
        }


        public Miasto GetMiastoCel()
        {
            return miastoCel;
        }

        public void SetMiastoCel(Miasto _miasto)
        {
            miastoCel = _miasto;
        }


        public Polozenie GetPozycja()
        {
            return pozycja;
        }

        public void SetPozycja(double _x, double _y)
        {
            pozycja.Zmien(_x, _y);
        }

        public abstract string Ladunek();

        public abstract string Rodzaj
        {
            get;
        }
    }
}
