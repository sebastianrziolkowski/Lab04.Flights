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
            return Math.Abs(Math.Sqrt(Math.Pow((b.x - a.x), 2) + (Math.Cos((a.x * Math.PI) / 180) * Math.Pow((b.y - a.y), 2))));
          
        }

        public static String SzacujCzasDotarcia(Samolot samolot)
        {

            double odleglosc = PoliczOdleglosc(samolot.getPozycja(), samolot.getMiastoCel().PolozenieM);
            double predkosc = samolot.Predkosc;
            if(double.IsNaN(odleglosc) || double.IsNaN(predkosc)){
                return DateTime.Now.ToString();
            }
            else
                return DateTime.Now.AddMinutes((odleglosc / predkosc) * 60).ToString();
        }
    }
}
