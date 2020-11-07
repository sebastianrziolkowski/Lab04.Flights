using System;
using System.Collections.Generic;
using System.Text;

namespace Dane.Model
{
    public class Samolot
    {
        private Polozenie Pozycja;
        private Miasto MiastoWylot;
        private Miasto MiastoCel;
        private string Identyfikator;
        public double Predkosc;



        public Samolot()
        {
            Pozycja = new Polozenie(0,0);
        }

        public Samolot(string identyfikator, double x, double y)
        {
            Identyfikator = identyfikator;
            Pozycja = new Polozenie(x, y);

        }

        public Samolot(string identyfikator, double predkosc)
        {
            Identyfikator = identyfikator;
            Predkosc = predkosc;
            Pozycja = new Polozenie(new double(), new double());
            MiastoWylot = new Miasto();
            MiastoCel = new Miasto() ;
         }
        
        public Samolot(string identyfikator, double predkosc, Miasto miastoWylotu)
        {
            Identyfikator = identyfikator;
            Predkosc = predkosc;
            MiastoWylot = miastoWylotu;
            MiastoCel = new Miasto();
            Pozycja = new Polozenie(MiastoWylot.PolozenieM.x, MiastoWylot.PolozenieM.y);

        }

        public string identyfikator
        {
            set { Identyfikator = value; }
            get { return Identyfikator; }    // Brak spojnosci z PDF-em
        }

        public Miasto getMiastoWylot()  // Brak spojnosci z PDF-em
        {
            return MiastoWylot;
        }


        public Miasto getMiastoCel()   // Brak spojnosci z PDF-em
        {
            return MiastoCel;
        }

        public void setMiastoCel(Miasto _miasto)   // Brak spojnosci z PDF-em
        {
            MiastoCel = _miasto;
        }


        public Polozenie getPozycja()   // Brak spojnosci z PDF-em
        {
            return Pozycja;
        }

        public void setPozycja(double _x, double _y)   // Brak spojnosci z PDF-em
        {
            Pozycja.Zmien(_x, _y);
        }
    }
}
