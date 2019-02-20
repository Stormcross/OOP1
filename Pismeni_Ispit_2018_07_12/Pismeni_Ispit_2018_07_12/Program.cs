using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// https://loomen.carnet.hr/pluginfile.php/1136454/mod_resource/content/0/2018.07.12.%20Pismeni%20ispit.pdf

namespace Pismeni_Ispit_2018_07_12
{
    class Program
    {
        static void Main(string[] args)
        {
            Cetverokut p1 = new Pravokutnik(2, 3);
            Cetverokut k1 = new Kvadrat(2);
            Cetverokut p2 = new Pravokutnik(4, 2);
            Cetverokut k2 = new Kvadrat(3);

            Console.WriteLine(p1.IspisiPodatke());
            Console.WriteLine(k1.IspisiPodatke());

            Spremnik s1 = new Spremnik();
            s1.DodajCetverokut(p1);
            s1.DodajCetverokut(k1);
            s1.DodajCetverokut(p2);
            s1.DodajCetverokut(k2);

            Console.WriteLine("Povrsina svih cetverokuta je: {0}", s1.PovrsinaSvihCetverokuta());
        }
    }
}
