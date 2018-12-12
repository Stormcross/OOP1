using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//https://loomen.carnet.hr/pluginfile.php/541424/mod_resource/content/0/2016.06.30.%20Pismeni%20ispit.pdf

namespace Pismeni_Ispit_2016_06_30
{
    class Program
    {
        static void Main(string[] args)
        {
            Osoba o1 = new Osoba("12345678901", "Mirko", "Miocic"); //1.6
            Osoba o2 = new Osoba("22554477888", "Nikola", "Nikic");
            Osoba o3 = new Osoba("99887766554", "Nikola", "Nikic");

            //Ispis osoba
            Console.WriteLine(o1.ispisiPodatke());
            Console.WriteLine(o2.ispisiPodatke());
            Console.WriteLine(o3.ispisiPodatke());

            //Novi OIB
            UnesiNoviOIB(o1);

            //1.6.2
            Console.WriteLine(ProvjeraImePrezime(o2, o3));
            //Zavrseno 1.## dio ispita



            Console.Read(); //dodano da sprijecimo gasenje programa



            //Dodatne metode
            void UnesiNoviOIB(Osoba osoba)//1.6.1
            {
                Console.WriteLine("\nUnesi novi OIB za osobu: {0}", osoba.VratiImeIPrezime());
                string OIB;
                Console.Write("Novi OIB: "); OIB = Console.ReadLine();
                osoba.ZadajOIB(OIB);
                Console.WriteLine("Podatak je dobro upisan...\n"); //U slucaju da je sve u redu. 
            }

            string ProvjeraImePrezime(object IP1, object IP2)
            {
                return String.Format("Osobe 2 i 3 imaju isto ime i prezime: {0}", IP1.Equals(IP2));
            }



        }


    }
}
