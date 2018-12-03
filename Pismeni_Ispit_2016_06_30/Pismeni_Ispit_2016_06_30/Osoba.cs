using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pismeni_Ispit_2016_06_30
{
    class Osoba:IEquatable<Osoba>
    {
        private string OIB; //1.1
        private string Ime;
        private string Prezime;

        public Osoba(string OIB, string Ime, string Prezime) //1.2
        {
            if (provjeriOIB())
            {
                this.OIB = OIB;
            }
            else
            {
                throw new ArgumentException("Predani podatak sadrzava znakove koji nisu brojevi!"); //potrebno je upotrijebiti DataMisalignedException, prouciti
            }
            
            this.Ime = Ime;
            this.Prezime = Prezime;
        }

        protected bool provjeriOIB() //1.3
        {
            return OIB.All(char.IsDigit) && OIB.Length == 11; //drugaciji nacin nego preporuceno na ispitu
        }

        public string ispisiPodatke() //1.4
        {
            return String.Format("Osoba: {0,1} {1,1} Oib: {2}", Ime,Prezime, OIB);
        }

        public bool Equals(Osoba other)
        {
            throw new NotImplementedException();
        }
    }
}
