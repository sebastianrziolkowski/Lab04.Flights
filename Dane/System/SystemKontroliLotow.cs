using System;
using System.Collections.Generic;
using System.Text;
using Dane.Model;

namespace Dane.System
{
    public class SystemKontroliLotow
    {
        public Samolot sledzonySamolot;

        public SystemKontroliLotow()
        {
            Console.WriteLine("System kontroli lotów został uruchomiony.");
        }

        public void SetSamolot(Samolot _samolot)
        {
            Console.WriteLine("Zarejestrowano " + _samolot.Identyfikator);
            sledzonySamolot = _samolot;
        }

        public void EkranObecnegoStanu()
        {
            Console.WriteLine("Obecny stan systemu [{0:t}]:", DateTime.Now);
            Console.WriteLine("{0,15} {1,4} {2,10} {3,12} {4,12} {5,10}",
           "Identyfikator", "Typ", "Ladunek", "Wylecial z", "Leci do", "Dotrze o");

            Console.WriteLine("{0,15} {1,4} {2,10} {3,12} {4,12} {5,10:t}",
            sledzonySamolot.Identyfikator,
            sledzonySamolot.Rodzaj,
            sledzonySamolot.Ladunek(),
            sledzonySamolot.GetMiastoWylot() != null ? sledzonySamolot.GetMiastoWylot().Nazwa : new Miasto().Nazwa,
            sledzonySamolot.GetMiastoCel() != null ? sledzonySamolot.GetMiastoCel().Nazwa : new Miasto().Nazwa,
            sledzonySamolot.GetPozycja() != null ? Narzedzia.SzacujCzasDotarcia(sledzonySamolot) : DateTime.Now.ToString("hh:mm tt"));
        }


        public void EkranObecnegoStanuXY()
        {
            Console.WriteLine("Obecny stan systemu [{0:t}]:", DateTime.Now);
            Console.WriteLine("{0,15} {1,4} {2,8} {3,8} {4,12} {5,12} {6,10}",
           "Identyfikator", "Typ", "Poz. X", "Poz. Y", "Wylecial z", "Leci do", "Dotrze o");

            Console.WriteLine("{0,15} {1,4} {2,8} {3,8} {4,12} {5,12} {6,10:t}",
            sledzonySamolot.Identyfikator,
            sledzonySamolot.Rodzaj,
            sledzonySamolot.GetPozycja() != null ? sledzonySamolot.GetPozycja().X : 0,
            sledzonySamolot.GetPozycja() != null ? sledzonySamolot.GetPozycja().Y : 0,
            sledzonySamolot.GetMiastoWylot() != null ? sledzonySamolot.GetMiastoWylot().Nazwa : new Miasto().Nazwa,
            sledzonySamolot.GetMiastoCel() != null ? sledzonySamolot.GetMiastoCel().Nazwa : new Miasto().Nazwa,
            sledzonySamolot.GetPozycja() != null ? Narzedzia.SzacujCzasDotarcia(sledzonySamolot) : DateTime.Now.ToString("hh:mm tt"));
        }
    }
}