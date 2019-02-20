using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pisemni_Ispit_2016_07_14.Razredi_geometrijski_oblici
{
    class Kruznica:GrafickiOblik
    {
        private double radius;

        public Kruznica(double radius)
        {
            this.radius = radius;
        }

        public void SetRadius(double radius)
        {
            this.radius = radius;
        }
        public double GetRadius()
        {
            return radius;
        }

        private double IzracunajPovrsinu()
        {
            return Math.Pow(radius, 2) * Math.PI;

        }
        public override double Povrsina()
        {
            return IzracunajPovrsinu();
        }
    }
}
