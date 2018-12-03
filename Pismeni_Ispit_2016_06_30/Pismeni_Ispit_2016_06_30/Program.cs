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
            Console.WriteLine(o1.ispisiPodatke());
            Console.WriteLine("Podatak je dobro upisan"); //U slucaju da je sve u redu. //ostali slucajevi


            



            Console.Read(); //da sprijecimo gasenje programa
        }


    }
}
