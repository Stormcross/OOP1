using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pisemni_Ispit_2016_07_14.Razredi_geometrijski_oblici
{
    class Pravokutnik:GrafickiOblik
    {
        private double visina;
        private double sirina;

        public Pravokutnik(double visina, double sirina)
        {
            this.visina = visina;
            this.sirina = sirina;
        }

        public void SetVisina(double visina)
        {
            this.visina = visina;
        }
        public void SetSirina(double sirina)
        {
            this.sirina = sirina;
        }

        public double GetVisina()
        {
            return visina;
        }
        public double GetSirina()
        {
            return sirina;
        }

        private double IzracunajPovrsinu()
        {
            return GetVisina() * GetSirina();

        }

        public override double Povrsina()
        {
            return IzracunajPovrsinu();
        }

    }

}
