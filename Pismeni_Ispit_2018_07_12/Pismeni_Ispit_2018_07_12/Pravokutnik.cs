using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pismeni_Ispit_2018_07_12
{
    class Pravokutnik : Cetverokut //1.2
    {
        public Pravokutnik(float a, float b) //konstruktor
        {
            if (a > 0)
            {
                this.a = a;
            }
            else
            {
                throw new ArgumentException("Duljina stranice A ne može biti manja od 0");
            }
            if (b > 0)
            {
                this.b = b;
            }
            else
            {
                throw new ArgumentException("Duljina stranice B ne može biti manja od 0");
            }
        }

        //moramo unjeti abstraktne tipve koje smo nasljedili iz cetverokut class
        public override float IzracunajPovrsinu()
        {
            return a * b;
        }

        public override string IspisiPodatke()
        {
            string ispis = "Pravokutnik duljine stranica: " + a + " ," + b + "povrsine: " + IzracunajPovrsinu(a, b);
            return ispis;
        }
    }
}
