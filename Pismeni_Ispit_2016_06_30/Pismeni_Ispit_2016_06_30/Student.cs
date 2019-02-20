using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pismeni_Ispit_2016_06_30
{

    class Student : Osoba //2.0
    {
        public Student(string OIB, string Ime, string Prezime) : base("12345678911", "OsobaIme", "OsobaPrezime")
        {
            this.OIB = provjeriOIB(OIB);
            this.Ime = Ime;
            this.Prezime = Prezime;
        }

        private List<string> Predmeti = new List<string>();
        private List<int> OcjenaPredmeta = new List<int>();
        private List<int> brojOcjena = new List<int>();

        private void DodajOcjenu(string naziv, int ocjena)
        {
            Console.Write("\nStudentu {0} dodana je ocjena: {1} za predmet: {2}", Ime, ocjena, naziv);
            OcjenaPredmeta.Add(ocjena);
        }

        public void DodajOcjenuZaPredmet(string nazivPredmeta, int ocjena)
        {
            if (Predmeti.Count == 0)
            {
                Predmeti.Add(nazivPredmeta);
                if (brojOcjena.Count == 0)
                {
                    brojOcjena.Add(1);
                    DodajOcjenu(nazivPredmeta, ocjena);

                }


            }
            else
            {
                bool test = false;
                for (int i = 0; i < Predmeti.Count; i++)
                {
                    if (String.Equals(nazivPredmeta, Predmeti[i]))
                    {
                        test = true;
                        if (brojOcjena[i] < 5)
                        {
                            DodajOcjenu(nazivPredmeta, ocjena);
                            brojOcjena[i]++;
                        }
                        else
                        {
                            Console.WriteLine("\nVec ste unjeli max 5 ocjena za taj predmet");
                            continue;
                        }
                    }
                    else if (i == Predmeti.Count - 1 && test == false)
                    {
                        Predmeti.Add(nazivPredmeta);
                        brojOcjena.Add(0);
                        Console.WriteLine("\n");
                    }
                }
            }
        }

        private void ProcitajOcjene(int r, string pred)
        {
            double  pros= 0;
            int brojPrijasnjihOcjena = 0;
            for (int i = 0; i < r; i++)
            {
                brojPrijasnjihOcjena += brojOcjena[i];


            }
            if (r==0)
            {
                
                for (int j = 0; j < brojOcjena[r]; j++)
                {
                    pros += (double)OcjenaPredmeta[j];
                }
                pros /= brojOcjena[r];

                Console.WriteLine("Predmet: {0}, ocjena: {1}", pred,pros);
            }
            else
            {
                int granica = brojOcjena[r] + brojPrijasnjihOcjena;
                for (int j = brojPrijasnjihOcjena ; j < granica; j++)
                {
                    pros += (double)OcjenaPredmeta[j];

                }
                pros /= brojOcjena[r];
                Console.WriteLine("Predmet: {0}, ocjena: {1:0.00}", pred,pros);
            }



        }

        

        public override void ispisiPodatke()
        {
            Console.WriteLine("\n\nStatus: Student, ");
            base.ispisiPodatke();
            int i = 0;
            foreach (string pred in Predmeti)
            {
                ProcitajOcjene(i, pred);
                i++;
            }

        }









    }
}
