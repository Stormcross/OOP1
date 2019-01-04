using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pisemni_Ispit_2016_07_14.Valjak
{
    class Valjak
    {
        private float polumjerBaze;
        private float visina;

        public Valjak()
        {
            visina = 1;
            polumjerBaze = 1;
        }

        public Valjak(float polumjerBaze,float visina)
        {
            this.polumjerBaze = polumjerBaze;
            this.visina = visina;
        }

        public void SetPolumjerBaze(float polumjerBaze)
        {
            this.polumjerBaze = polumjerBaze;
        }

        public float GetPolumjerBaze()
        {
            return polumjerBaze;
        }

        public void SetVisina(float visina)
        {
            this.visina = visina;
        }

        public float GetVisina()
        {
            return visina;
        }

        public float PolumjerBaze
        {
            get
            { return GetPolumjerBaze(); }
            set
            {
                SetPolumjerBaze(value);
            }
        }

        public float Visina
        {
            get
            {
                return GetVisina();
            }
            set
            {
                SetVisina(value);
            }
        }

        private double PovrsinaBaze()
        {
            return Math.Pow(polumjerBaze, 2) * Math.PI;
        }
        private double PovrsinaPlasta()
        {
            return 2 * Math.PI * polumjerBaze * visina;
        }
        public double UkupnaPovrsina
        {
            get
            {
                return PovrsinaBaze() + PovrsinaPlasta();
            }
        }
        public double Volumen
        {
            get
            {
                return PovrsinaPlasta() * PovrsinaBaze();
            }
        }
        public override string ToString()
        {
            return String.Format("Visina:" + visina + " Radius baze:" + polumjerBaze);
        }

    }
}

