using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KosaricaVjezba.PoslovnaLogika
{
    class VlasnikKosarice
    {
        private string id;
        private string naziv;
        private string adresa;

        public VlasnikKosarice(string id, string naziv, string adresa)
        {
            this.id = id;
            this.naziv = naziv;
            this.adresa = adresa;
        }
        //vrati
        public string VratiID() { return id; }
        public string VratiNaziv() { return naziv; }
        public string VratiAdresu() { return adresa; }
        //promjeni
        public void PromjeniNaziv(string naziv) { this.naziv = naziv; } 
        public void PromjeniAdresu(string adresa) { this.adresa = adresa; }
        public override string ToString()//vazno za prouciti
        {
            return String.Format("{0} / {1}, {2}", id, naziv, adresa);
        }
    }
}
