using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KosaricaVjezba.PoslovnaLogika
{
    class StavkaKosarice
    {
        //private
        private string opis;
        private int kolicina;
        private decimal cijena;
        //konsturktor
        public StavkaKosarice(string opis,int kolicina, decimal cijena)
        {
            this.opis = opis;
            this.kolicina = kolicina;
            this.cijena = cijena;
        }
        public StavkaKosarice(string opis, decimal cijena)
        {
            this.opis = opis;
            this.cijena = cijena;
            kolicina = 1;
        }
        //vrati
        public string VratiOpis() { return opis; }
        public decimal VratiCijenu() { return cijena; }
        public decimal VratiVrijednosti() { return cijena * kolicina; }
        public override string ToString()//vazno za prouciti
        {
            return String.Format("Opis: {0,-30} {1,5} kom {2,10:F2} kn   Ukupno: {3,5} kn", opis, kolicina, cijena,VratiVrijednosti());
        }

    }
}
