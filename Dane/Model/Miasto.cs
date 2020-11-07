using System;
using System.Collections.Generic;
using System.Text;

namespace Dane.Model
{
    public class Miasto
    {
        public Miasto()
        {
            Nazwa = "Brak";
            PolozenieM = new Polozenie(0,0);
        }
        public string Nazwa;
        public Polozenie PolozenieM;
    }
}
