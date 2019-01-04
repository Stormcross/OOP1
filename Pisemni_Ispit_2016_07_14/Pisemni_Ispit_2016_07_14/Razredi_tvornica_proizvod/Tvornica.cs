using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pisemni_Ispit_2016_07_14.Razredi_tvornica_proizvod
{
    class Tvornica
    {
        static private int najveciKapacitet = 100;
        private int kapacitet;
        private string ime;

        List<Proizvod> proizvodi = new List<Proizvod>();

        public Tvornica(int kapacitet, string ime)
        {
            if (kapacitet > najveciKapacitet)
            {
                throw new ArgumentOutOfRangeException("kapacitet", "Najveci dopusteni kapacitet je premasen");
            }
            else
            {
                this.kapacitet = kapacitet;
            }
            if (ime.Length == 0)
            {
                throw new ArgumentNullException("Ime", "Naziv tvornice ne moze biti prazan niz");
            }
        }

        public Proizvod proizvedi(string naziv, int cijena)
        {
            Proizvod p = new Proizvod(naziv, cijena);
            proizvodi.Add(p);
            return p;
        }

        public Proizvod NajSkuplji ()
        {
            proizvodi.Sort();
            return proizvodi[0];
        }

        public Proizvod NajJeftiniji()
        {
            proizvodi.Sort();
            return proizvodi[proizvodi.Count-1];
        }

    }
}
