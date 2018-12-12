using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pismeni_Ispit_2016_06_30
{
    
    

    class Student:Osoba //2.0
    {
        public Student(string OIB, string Ime, string Prezime):base("12345678911","OsobaIme","OsobaPrezime")
        {
            this.OIB = provjeriOIB(OIB);
            this.Ime = Ime;
            this.Prezime = Prezime;
        }

        public void UpisiNazivPredmeta(string predmet)
        {
            nazivPredmeta.Add(predmet);
        }

        //prouciti i nastaviti
        public void DodajOcjenuZapredmet(string predmet, int ocjena)
        {
            
           

        }

        public override string ispisiPodatke()
        {
            Console.Write("Status: Student, ");
            return base.ispisiPodatke(); 
        }

        public List<string> nazivPredmeta=new List<string>();
        public List<int> ocjena; //new List<int>(new int [5]); 







    }
}
