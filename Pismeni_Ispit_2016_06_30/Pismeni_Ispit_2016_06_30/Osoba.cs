using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pismeni_Ispit_2016_06_30
{
    class Osoba : IEquatable<Osoba>
    {
        protected string OIB; //1.1
        protected string Ime;
        protected string Prezime;

        public Osoba(string OIB, string Ime, string Prezime) //1.2
        {

            this.OIB = provjeriOIB(OIB);
            this.Ime = Ime;
            this.Prezime = Prezime;
        }

        //Metoda zadaj
        public void ZadajOIB(string OIB) //1.6
        {
            this.OIB = provjeriOIB(OIB);
        }

        //Metode vrati
        public string VratiImeIPrezime() { return String.Format("{0}, {1}", Ime, Prezime); }
        public string VratiIme() { return Ime; }
        public string VratiPrezime() { return Prezime; }

        //Ostale metode
        protected string provjeriOIB(string OIB) //1.3 Kako je to povezano s 1.6? pitati, provjeriti
        {
            bool test = false;
            if (OIB.All(char.IsDigit) != true)
            {
                throw new DataMisalignedException("Predani podatak sadžava znakove koji nisu brojevi!");
            }
            else
            {
                if (OIB.Length != 11)
                {
                    throw new ArgumentOutOfRangeException("OIB", "Predani podatak sadrzava previse ili premalo znakova!");
                }
                else { test = true; }
            }
            if (test == true) return OIB;
            else return String.Format("Greska pri unosu OIB-a");
        }

        public virtual void ispisiPodatke() //1.4
        {
            Console.WriteLine("Info: {0,4} {1,4} Oib: {2}", Ime, Prezime, OIB);
        }

        public bool Equals(Osoba other) //1.5
        {
            //throw new NotImplementedException();
            return Ime == other.VratiIme() &&
                Prezime == other.VratiPrezime();
        }

        public override bool Equals(object obj)
        {
            return this.Equals((Osoba)obj);
        }



        //Ovo dalje dolje je samo razmisljanje, ne ulazi u kod 

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







    }
}
