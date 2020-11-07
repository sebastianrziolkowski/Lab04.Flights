using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;
using Dane.Model;
using Dane.System;

namespace Dane.Baza
{
    public class Repozytorium
    {
        public Miasto WezMiasto()
        {
            Miasto miasto = new Miasto();
            miasto.Nazwa = "Londyn";
            miasto.PolozenieM.Zmien(1123, -2142);
            return miasto;
        }

        public Miasto WezMiasto(string nazwaMiasta)
        {

            Miasto miasto = new Miasto();
            miasto.Nazwa = nazwaMiasta;
            double posX = Math.Truncate(100 *(-3000 + (new Random(Narzedzia.GetRandomInt()).NextDouble() * (3000 -(-3000)))) / 100);
            double posY = Math.Truncate(100 * (-3000 + (new Random(Narzedzia.GetRandomInt()).NextDouble() * (3000 - (-3000)))) / 100);
            miasto.PolozenieM.Zmien(posX, posY);
            return miasto;
        }

        public Samolot WezSamolot()
        {
            Samolot samolot = new Samolot();
            samolot.identyfikator = "Lot 94124";
            samolot.setPozycja(131,2255);
            return samolot;
        }

        public Samolot WezSamolot(Miasto miastoWylotu)
        {
            return new Samolot("Lot 23513", 900, miastoWylotu);
        }
    }
}
