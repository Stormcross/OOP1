using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Razlomak_Tocka.Zadaci
{
    class Program
    {
        //postavljanje liste razloka
        static List<Razlomak> ListaRazlomaka = new List<Razlomak>();

        static void Main(string[] args)
        {
            //postavimo razlomke
            Razlomak r1 = new Razlomak(15, 5);
            Razlomak r2 = new Razlomak(5, 20);
            Razlomak r3 = new Razlomak(24, 8);
            //dodavanje na listu razlomaka
            ListaRazlomaka.Add(r1);
            ListaRazlomaka.Add(r2);
            ListaRazlomaka.Add(r3);
            //ispisivanje razlomaka
            Console.WriteLine("Razlomak 1: {0} / {1} = {2}, razlomak ispravan: {3}", r1.VratiBrojnik(), r1.VratiNazivnik(), r1.PretvoriUFloat(), r1.Ispravan());
            Console.WriteLine("Razlomak 2: {0} / {1} = {2}, razlomak ispravan: {3}", r2.VratiBrojnik(), r2.VratiNazivnik(), r2.PretvoriUFloat(), r2.Ispravan());
            Console.WriteLine("Razlomak 3: {0} / {1} = {2}, razlomak ispravan: {3}", r3.VratiBrojnik(), r3.VratiNazivnik(), r3.PretvoriUFloat(), r3.Ispravan());
            //ispis po velicini
            Console.WriteLine("Ispis po velicini: ");
            foreach (Razlomak r in ListaRazlomaka)
            {
                Console.Write(r.PretvoriUFloat() + ", ");
            }
            //Usporedba razlomaka
            //usporedba da li su dva razlomka jednaka
            if (r1.Equals(r2))
            {
                Console.WriteLine("\nIsti su!");
            }
            else
            {
                Console.WriteLine("\nNisu isti!");
            }
            Console.Read();


        }
    }
}
