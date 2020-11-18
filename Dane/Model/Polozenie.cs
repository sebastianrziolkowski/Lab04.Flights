using System;
using System.Collections.Generic;
using System.Text;

namespace Dane.Model
{
    public class Polozenie
    {
        private double x;
        private double y;

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

        public double X
        {
            get => x;
            set => x = value;
        }
        public double Y
        {
            get => y;
            set => y = value;
        }
    }
}
