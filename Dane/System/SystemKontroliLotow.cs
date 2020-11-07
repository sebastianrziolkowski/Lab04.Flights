﻿using System;
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
            Console.WriteLine("Zarejestrowano " + _samolot.identyfikator);
            sledzonySamolot = _samolot;
        }

        public void EkranObecnegoStanu()
        {
            Console.WriteLine("Obecny stan systemu [{0:t}]:", DateTime.Now);
            Console.WriteLine("{0,15} {1,8} {2,8} {3,12} {4,12} {5,10}",
           "Identyfikator", "Poz. X", "Poz. Y", "Wylecial z", "Leci do", "Dotrze o");

            Console.WriteLine("{0,15} {1,8} {2,8} {3,12} {4,12} {5,10:t}",
            sledzonySamolot.identyfikator,
            sledzonySamolot.getPozycja().x,
            sledzonySamolot.getPozycja().y,
            sledzonySamolot.getMiastoWylot() != null ? sledzonySamolot.getMiastoWylot().Nazwa : new Miasto().Nazwa,
            sledzonySamolot.getMiastoCel() != null ? sledzonySamolot.getMiastoCel().Nazwa : new Miasto().Nazwa,
            Narzedzia.SzacujCzasDotarcia(sledzonySamolot));
        }
    }
}