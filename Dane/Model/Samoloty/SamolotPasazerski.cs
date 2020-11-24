using System;
using System.Collections.Generic;
using System.Text;

namespace Dane.Model.Samoloty
{
    class SamolotPasazerski : Samolot
    {
        private int iloscMiejsc;
        private int iloscPasazerow;

        public SamolotPasazerski(int iloscMiejsc, int iloscPasazerow) : base("432B", 900)
        {
            IloscMiejsc = iloscMiejsc;
            IloscPasazerow = iloscPasazerow;
        }

        public SamolotPasazerski(String identyfikator, double predkosc, int iloscMiejsc) : base(identyfikator, predkosc)
        {
            IloscMiejsc = iloscMiejsc;
        }

        public int IloscMiejsc
        {
            get => iloscMiejsc;
            protected set => iloscMiejsc = value;
        }

        public int IloscPasazerow
        {
            get => iloscPasazerow;
            set => iloscPasazerow = value;
        }

        public override string Ladunek()
        {
            return iloscPasazerow.ToString() + "/" + iloscMiejsc.ToString();
        }

        public override string Rodzaj
        {
            get => "P";
        }
    }
}
