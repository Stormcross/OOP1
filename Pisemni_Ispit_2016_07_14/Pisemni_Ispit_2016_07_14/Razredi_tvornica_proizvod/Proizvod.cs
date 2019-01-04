using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pisemni_Ispit_2016_07_14.Razredi_tvornica_proizvod
{
    class Proizvod:IComparable<Proizvod>
    {
        private string naziv;
        private int cijena;

        public Proizvod(string naziv, int cijena)
        {
            this.naziv = naziv;
            this.cijena = cijena;
        }

        public string Naziv
        {
            get
            {
                return naziv;
            }
        }

        public int Cijena
        {
            get
            {
                return cijena;
            }
        }

        public int CompareTo(Proizvod other)
        {
            //Abecedno sortiramo ako je cijena ista
            if (this.cijena==other.cijena)
            {
                return this.naziv.CompareTo(other.naziv);
            }
            return other.cijena.CompareTo(this.cijena);
            //usperđujemo cijenu od vise prema nizoj
        }

        public override string ToString()
        {
            return "- Naziv: " + naziv + " Cijena: " + cijena;
        }
    }
}
