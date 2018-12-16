using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valjak_skladiste_kamion.Razred
{
    class Kamion
    {
        private double kapacitet;

        public Kamion(double kapacitet) { this.kapacitet = kapacitet; }

        private List<Valjak> transportValjka = new List<Valjak>();

        public double GetKapacitet() { return kapacitet; }

        public void Ukrcaj(Skladiste skladiste)
        {
            //foreach (Valjak item in skladiste.GetValjaks)
            //{
            //    if (k > 0)
            //    {
            //        if (skladiste.GetValjaks.Count != 0)
            //        {
            //            transportValjka.Add(item);
            //            k -= item.Volumen();
            //            skladiste.GetValjaks.RemoveAt(0);
            //        }
            //        else
            //        {
            //            break;
            //        }
            //    }
            //}

            int brojac = 0;

            for (int i = 0; i < skladiste.GetValjaks.Count;) //ubacuje na kamion i brise iz liste u skladistu
            {
                //double test = kapacitet - skladiste.GetValjaks.ElementAt(i).Volumen();
                if (skladiste.GetValjaks.Count != 0 && (kapacitet - skladiste.GetValjaks.ElementAt(i).Volumen()>0))
                {
                    transportValjka.Add(skladiste.GetValjaks.ElementAt(i));
                    kapacitet -= skladiste.GetValjaks.ElementAt(i).Volumen();
                    skladiste.GetValjaks.RemoveAt(i);
                }
                else if(skladiste.GetValjaks.Count != 0)
                {
                    i++;
                }
                else
                {
                    break;
                }
            }
        }

        public void IspisStanjaKamion(Kamion kamion)
        {
            double ukupniVolumenUKamionu = 0;
            foreach (Valjak valjak in kamion.transportValjka)
            {
                Console.WriteLine("Valjak u kamionu: {0:0.00}", valjak.Volumen());
                ukupniVolumenUKamionu += valjak.Volumen();
            }
            Console.WriteLine("Ostalo kapaciteta u kamionu:{0:0.00}", kapacitet);
        }

    }
}
