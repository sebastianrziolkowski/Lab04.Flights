using System;
using System.Collections.Generic;
using System.Text;

namespace Dane.Model
{
    public class Polozenie
    {
        public double x;
        public double y;

        public Polozenie(double _x, double _y)
        {
            x = _x;
            y = _y;
        }

        public void Zmien(double _x, double _y)
        {
            x = _x;
            y = _y;
        }
    }
}
