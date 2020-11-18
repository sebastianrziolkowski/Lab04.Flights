using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;
using Dane.Model;

namespace Dane.System
{
    public class Narzedzia
    {

        public static int GetRandomInt()
        {
            using (RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider())
            {
                byte[] randomNumber = new byte[4];//4 for int32
                rng.GetBytes(randomNumber);
                return BitConverter.ToInt32(randomNumber, 0);
            }
        }


        public static double PoliczOdleglosc(Polozenie a, Polozenie b)
        {
            return Math.Sqrt(Math.Pow((b.X - a.X), 2) * Math.Pow((b.Y - a.Y), 2));
          
        }

        public static String SzacujCzasDotarcia(Samolot samolot)
        {

            double odleglosc = PoliczOdleglosc(samolot.GetPozycja(), samolot.GetMiastoCel().PolozenieM);
            double predkosc = samolot.predkosc;
            if(double.IsNaN(odleglosc) || double.IsNaN(predkosc)){
                return DateTime.Now.ToString();
            }
            else
                return DateTime.Now.AddMinutes((odleglosc / predkosc) * 60).ToString();
        }
    }
}
