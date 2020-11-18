using System;
using System.Collections.Generic;
using System.Text;

namespace Dane.Model
{
    public class Miasto
    {
        private string name;
        private Polozenie polozenieM;
        public Miasto()
        {
            Nazwa = "Brak";
            PolozenieM = new Polozenie(0,0);
        }
        public string Nazwa
        {
            get => name;
            set => name = value;
        }
        public Polozenie PolozenieM
        {
            get => polozenieM;
            set => polozenieM = value;
        }
    }
}
