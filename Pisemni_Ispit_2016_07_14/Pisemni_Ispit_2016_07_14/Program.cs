using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pisemni_Ispit_2016_07_14.Razredi_geometrijski_oblici;
using Pisemni_Ispit_2016_07_14.Razredi_tvornica_proizvod;
using Pisemni_Ispit_2016_07_14.Osobe;
using Pisemni_Ispit_2016_07_14.Valjak;

namespace Pisemni_Ispit_2016_07_14
{
    class Program
    {
        //Pocinje 1.0 zadatak
        static List<GrafickiOblik> oblici = new List<GrafickiOblik>();

        static void Main(string[] args)
        {
            Kruznica k1 = new Kruznica(3);
            Kruznica k2 = new Kruznica(4);
            Kruznica k3 = new Kruznica(5);

            Pravokutnik p1 = new Pravokutnik(2, 3);
            Pravokutnik p2 = new Pravokutnik(3, 4);
            Pravokutnik p3 = new Pravokutnik(4, 5);

            //umetanje u listu
            oblici.Add(k1);
            oblici.Add(k2);
            oblici.Add(k3);
            oblici.Add(p1);
            oblici.Add(p2);
            oblici.Add(p3);

            double ukupnaPovrsina = 0d;

            foreach (GrafickiOblik item in oblici)
            {
                ukupnaPovrsina += item.Povrsina();
            }

            Console.WriteLine("Zadatak 1.\nUkupna povrsina svih oblika: {0}\n", String.Format("{0:.000 }", ukupnaPovrsina)); //Postavljeno na 3 decimale i zaokruzeno na prvu najblizu
            //Zavrsen 1.0 zadatak

            //Pocetak 2.0 zadatak
            //Stvorimo tvornicu
            Tvornica tvornica1 = new Tvornica(60, "Metalac");
            //prizvedemo nekoliko artikala
            tvornica1.proizvedi("Mlijeko", 12);
            tvornica1.proizvedi("Kruh", 5);
            tvornica1.proizvedi("Auto", 10000);
            tvornica1.proizvedi("Monitor", 400);

            Console.WriteLine("Zadatak 2.\nNajskuplji u tvornici: {0}", tvornica1.NajSkuplji().ToString());
            Console.WriteLine("Najjeftiniji u tvornici: {0}", tvornica1.NajJeftiniji().ToString());
            //Zavrsetak zadatak 2.0

            //Pocetak zadatak 3.0
            //Stvorimo 4 osobe
            Osoba prva = new Osoba("Marko");
            Osoba druga = new Osoba("Nina");
            Osoba treca = new Osoba("Viktorija");
            Osoba cetvrta = new Osoba("Neven");
            //dodamo osobe na listu
            List < Osoba > osobe= new List<Osoba>();
            osobe.Add(prva);
            osobe.Add(druga);
            osobe.Add(treca);
            osobe.Add(cetvrta);
            //prva.Sljedeca = druga;
            Console.WriteLine("\nZadatak 3.");
            for (int i=0; i < osobe.Count-1; i++) //nije dobro za sad, just for the zadatak nek bude ovako, potrebno s ref i provjerom
            {
                    Console.WriteLine("{0}",osobe[i].Ime);
            }
            //Zavrsen 3.0 zadatak

            //Pocetak 4.0



        }
    }
}


