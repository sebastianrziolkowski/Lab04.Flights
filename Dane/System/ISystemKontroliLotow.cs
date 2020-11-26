using System;
using System.Collections.Generic;
using System.Text;
using Dane.Model;

namespace Dane.System
{
    interface ISystemKontroliLotow
    {
        public void ZarejestrujSamolot(Samolot samolot);
        public void PokazWidok(Widok widok);
    }
}
