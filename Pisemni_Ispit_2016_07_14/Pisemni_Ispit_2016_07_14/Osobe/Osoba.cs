using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pisemni_Ispit_2016_07_14.Osobe
{
    class Osoba
    {
        private string ime;
        private Osoba sljedeca;
        public string Ime
        {
            get
            { return ime; }
            set
            { ime = value; }
        }
        //konstruktor
        public Osoba(string ime)
        {
            this.ime = ime;
        }

        public Osoba Sljedeca
        {
            get { return this.sljedeca; }
            set { sljedeca.ime=this.ime; }
        }


    }
}
