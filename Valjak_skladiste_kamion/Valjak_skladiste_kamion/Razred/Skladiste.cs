using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valjak_skladiste_kamion.Razred
{
    class Skladiste
    {
        private List<Valjak> ListaValjak = new List<Valjak>();

        public void DodajUSkladiste(Valjak valjak)
        {
            if (valjak.Volumen() > 10 && valjak.Volumen() < 100)
            {
                ListaValjak.Add(valjak);
            }
        }
        //svojstvo dohvat liste
        public List<Valjak> GetValjaks
        {
            get { return ListaValjak; }
        }

        public void toString()
        {
            int brojac = 1;
            foreach (Valjak valjak in ListaValjak)
            {
                Console.WriteLine("******\n" +
                    "Valjak {0:}:\nVolumen:{1:0.00}" +
                    "\n******", brojac++, valjak.Volumen());
            }
        }
    }
}
