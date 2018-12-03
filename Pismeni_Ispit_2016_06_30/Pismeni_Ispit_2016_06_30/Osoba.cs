using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pismeni_Ispit_2016_06_30
{
    class Osoba : IEquatable<Osoba>
    {
        private string OIB; //1.1
        private string Ime;
        private string Prezime;

        public Osoba(string OIB, string Ime, string Prezime) //1.2
        {

            this.OIB = provjeriOIB(OIB);
            this.Ime = Ime;
            this.Prezime = Prezime;
        }

        protected string provjeriOIB(string OIB) //1.3 Kako je to povezano s 1.6? pitati, provjeriti
        {
            bool test = false;

            if (OIB.All(char.IsDigit) != true)
            {
                throw new DataMisalignedException("Predani podatak sadžava znakove koji nisu brojevi!");
                
            }
            else {
                if (OIB.Length != 11)
                {
                    throw new ArgumentOutOfRangeException("OIB", "Predani podatak sadrzava previse ili premalo znakova!");
                }
                else { test = true; }
            }

            if (test == true) return OIB;
            else return String.Format("Greska pri unosu OIB-a");

        }



        //drugi nacin - prouciti jos kaj treba
        //try
        //{
        //    OIB.All(predicate: char.IsDigit);

        //}
        //catch (global::System.DataMisalignedException)
        //{
        //    throw new DataMisalignedException("Predani podatak sadžava znakove koji nisu brojevi!");
        //}

        //try
        //{
        //    if (OIB.Length == 11)
        //    { return OIB; }


        //}
        //catch (global::System.ArgumentOutOfRangeException)
        //{
        //    throw new ArgumentOutOfRangeException("Predani podatak sadrzava previse ili premalo znakova!");
        //}

        //if (OIB.All(char.IsDigit) && OIB.Length == 11)
        //{
        //    return OIB;
        //}
        //else
        //{
        //    return String.Format("Greska kod unosa OIB-a");
        //}






        public string ispisiPodatke() //1.4
        {
            return String.Format("Osoba: {0,1} {1,1} Oib: {2}", Ime, Prezime, OIB);
        }




        public bool Equals(Osoba other) //1.5
        {
            //throw new NotImplementedException();
            return Ime == other.Ime &&
                Prezime == other.Prezime;
        }
    }
}
