using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kol1_vjezba
{
    class Program
    {

        public struct Knjiga
        {
            public string naslov;
            public string autor;
            public double cijena;
            public int kolicina;

        }

        

        static List<Knjiga> PopisKnjiga = new List<Knjiga>();

        //ukupni iznos
        //najjeftinija knjiga
        //prosjek cijene

        static void Main(string[] args)
        {

            Knjiga k1 = new Knjiga();
            k1.naslov = "Knjiga 1";
            k1.autor = "Autor 1";
            k1.cijena = 10;
            k1.kolicina = 1;
            PopisKnjiga.Add(k1);



            Knjiga k2 = new Knjiga();
            k2.naslov = "Knjiga 2";
            k2.autor = "Autor 2";
            k2.cijena = 20;
            k2.kolicina = 2;
            PopisKnjiga.Add(k2);


            Knjiga k3 = new Knjiga();
            k3.naslov = "Knjiga 3";
            k3.autor = "Autor 3";
            k3.cijena = 30;
            k3.kolicina = 3;
            PopisKnjiga.Add(k3);


            //Dodatne varijable, vjerojatno se moze i bez toga
            double zajednickaUkupnaCijena = 0;
            double zbrojCijena = 0;
            //Ispis

            foreach (Knjiga k in PopisKnjiga)
            {
                Console.WriteLine("\nKnjiga: " + k.naslov + " ima cijenu {0}kn i {1} komad/a", k.cijena,k.kolicina);
                Console.WriteLine("Ukupnu cijena je {0}", UkupnaCijena(k));
                
                zajednickaUkupnaCijena += UkupnaCijena(k);
                zbrojCijena += k.cijena;
            }
            Console.WriteLine("\nUkupna cijena svih knjiha zajedno je: {0}kn", zajednickaUkupnaCijena);
            Prosjek(zajednickaUkupnaCijena, zbrojCijena);
            NajJeftinija();
     


            //Izracunati
            //Prosjek
            void Prosjek(double _cijena1, double _cijena2)
            {
                double prosjek = 0;
                prosjek = _cijena1 / PopisKnjiga.Count;
                Console.WriteLine("\nProsjek ukupnih cijena s kolicinom je: {0}", prosjek);
                prosjek = 0; //vratimo prosjek na 0
                prosjek = _cijena2 / PopisKnjiga.Count;
                Console.WriteLine("\nProsjek ukupnih cijena zasebno je: {0}", prosjek);

            }

            //Ukupna cijena
            double UkupnaCijena(Knjiga k)
            {
                double ukupnaCijena = 0;
                ukupnaCijena = k.cijena * k.kolicina;

                return ukupnaCijena;
            }

            //Najjeftinija
            void NajJeftinija()
            {
                double najJeftinija = k1.cijena;
                foreach (Knjiga k in PopisKnjiga)
                {
                    if (k.cijena < najJeftinija)
                    {
                        najJeftinija = k.cijena;
                    }
                }

                Console.WriteLine("\nNaj jeftinija knjiga ima cijenu:  {0}", najJeftinija);

            }




            Console.ReadLine();
        }
        
    }
}
