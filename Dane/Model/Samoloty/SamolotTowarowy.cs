using System;
using System.Collections.Generic;
using System.Text;

namespace Dane.Model.Samoloty
{
    class SamolotTowarowy : Samolot
    {
        private double wagaLadunku; 
        private double maksymalnaWaga;

        public SamolotTowarowy(string _identyfikator, double predkosc, Miasto miastoWylotu, double _maksymalnaWaga) : base(_identyfikator, predkosc, miastoWylotu)
        {
            maksymalnaWaga = _maksymalnaWaga;
        }

        public double WagaLadunku { get => wagaLadunku; set => wagaLadunku = value; }

        public double GetMaksymalnaWaga()
        {
            return maksymalnaWaga;
        }

        protected double MaksymalnaWaga { set => maksymalnaWaga = value; }

        public override string Ladunek()
        {
            return wagaLadunku.ToString() + "/" + maksymalnaWaga.ToString();
        }

        public override string Rodzaj
        {
            get => "T";
        }
    }

}
