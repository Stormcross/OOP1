using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//https://loomen.carnet.hr/pluginfile.php/456320/mod_resource/content/1/2.%20Prakti%C4%8Dni%20kolokvij.pdf OOP1 loomen MEV
namespace Valjak_skladiste_kamion.Razred
{
    class Program
    {
        static void Main(string[] args)
        {
            Valjak v1 = new Valjak(1,3);
            Valjak v2 = new Valjak(2, 3);
            Valjak v3 = new Valjak(3,3 );
            Valjak v4 = new Valjak(1, 4);
            Valjak v5 = new Valjak(1, 10);

            Console.WriteLine("V1:\n" + v1.toString());
            Console.WriteLine("V2:\n" + v2.toString());
            Console.WriteLine("V3:\n" + v3.toString());
            Console.WriteLine("V4:\n" + v4.toString());
            Console.WriteLine("V5:\n" + v5.toString());


            Skladiste skladiste = new Skladiste();
            skladiste.DodajUSkladiste(v1);
            skladiste.DodajUSkladiste(v2);
            skladiste.DodajUSkladiste(v3);
            skladiste.DodajUSkladiste(v4);
            skladiste.DodajUSkladiste(v5);

            Console.WriteLine("\nPopis skladista valjaka s volumenom od 10 do 100:");
            skladiste.toString();

            Kamion kamion = new Kamion(100);
            Console.WriteLine("Dolazi kamion kapaciteta: {0}",kamion.GetKapacitet());

            kamion.Ukrcaj(skladiste);
            kamion.IspisStanjaKamion(kamion);
        }
    }
}
