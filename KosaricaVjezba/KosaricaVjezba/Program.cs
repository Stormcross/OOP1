using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace KosaricaVjezba.PoslovnaLogika 
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ude marko u ducan
            VlasnikKosarice marko = new VlasnikKosarice("marko@mev.com", "Marko Markovic", "Mihovljanska 12,Čakovec");

            Console.WriteLine("Kupac: {0}", marko);

            //Marko promjena adrese
            marko.PromjeniAdresu("A.G.Matosa 123, Varazdin");

            Console.WriteLine("\nKupac mjenja adresu..\nKupac: {0}", marko);

            //Marko uzima kosaricu
            Kosarica markovaKosarica = new Kosarica(marko);


            //Stavke u kosarici marko kupuje
            //StavkaKosarice jabuka = new StavkaKosarice("Crvena jabuka", 2, 4.99); //redundanto
            markovaKosarica.DodajStavku(new StavkaKosarice("TV LG 58 615", 8667.23m));
            markovaKosarica.DodajStavku(new StavkaKosarice("Produzni kabel",2   ,54.45m));
            markovaKosarica.DodajStavku(new StavkaKosarice("Antena",1  ,123.50m));

            //ispisati kosaricu
            Console.WriteLine("\nIspis kosarice..\nID:{0} \nKupac:{1} \nStatus:{2} \nStavke:",
                markovaKosarica.VratiID(),
                markovaKosarica.VratiVlasnika(),
                markovaKosarica.VratiStatus());

            //ispis stavaka-trebamo petlju
            int brojac = 1;
            foreach (StavkaKosarice s in markovaKosarica.VratiStavke())
            {
                Console.WriteLine("{0}. {1} ", brojac++, s);
            }

            //ukupno
            Console.WriteLine("\nUkupna cijena racuna: {0} kn\n", markovaKosarica.VratiVrijednost());

       

        }
    }
}
