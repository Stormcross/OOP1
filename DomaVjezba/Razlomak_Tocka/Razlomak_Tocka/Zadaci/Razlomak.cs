using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Razlomak_Tocka.Zadaci
{
    class Razlomak:IComparable<Razlomak>,IEquatable<Razlomak>
    {
        //private
        private int brojnik;
        private int nazivnik;
        //konstruktor
        public Razlomak(int brojnik, int nazivnik)
        {
            this.brojnik = brojnik; this.nazivnik = nazivnik;
        }
        //zadaj
        public void ZadakBrojnik(int brojnik) { this.brojnik = brojnik; }
        public void ZadajNazivnik(int nazivnik) { this.nazivnik = nazivnik; }
        //vrati
        public int VratiBrojnik() { return brojnik; }
        public int VratiNazivnik() { return nazivnik; }
        //pretvori u float
        public float PretvoriUFloat() { return (float)brojnik / nazivnik; }
        //ispravan razlomak razlicit od 0
        public string Ispravan()
        {
            return (nazivnik != 0) ? String.Format("Ispravan") : String.Format("Nije ispravan");
        }
        //najveci zajednicki djelitelj brojnika i nazivnika
        private int nzd()
        {
            int rez = 1;
            for (int i = 0; i < Math.Min(brojnik, nazivnik); i++)
            {
                if (brojnik % i == 0 && nazivnik % i == 0)
                {
                    rez = i;
                }
            }
            return rez;
        }
        //skrati razlomak
        public void SkratiRazlomak()
        {
            brojnik /= nzd();
            nazivnik /= nzd();
        }


        //interface koristenje
        public int CompareTo(Razlomak other)
        {
            if (PretvoriUFloat()>other.PretvoriUFloat())
            {
                return 1;
            }
            else if (PretvoriUFloat()<other.PretvoriUFloat())
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }

        public bool Equals(Razlomak other)
        {
            return brojnik == other.VratiBrojnik() && nazivnik == other.VratiNazivnik();
        }
    }
}
