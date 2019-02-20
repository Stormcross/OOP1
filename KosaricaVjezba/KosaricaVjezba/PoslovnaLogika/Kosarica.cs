using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KosaricaVjezba.PoslovnaLogika
{
    class Kosarica
    {
        //private
        private Guid id;
        private VlasnikKosarice vlasnik;
        private StatusKosarice status;
        //stavke
        private List<StavkaKosarice> stavke;

        //kosntruktor
        public Kosarica(VlasnikKosarice vlasnik)
        {
            id = Guid.NewGuid();
            status = StatusKosarice.Prazna;
            stavke = new List<StavkaKosarice>();
            this.vlasnik = vlasnik;
        }

        //public
        public VlasnikKosarice VratiVlasnika() { return vlasnik; }
        public Guid VratiID() { return id; }
        public StatusKosarice VratiStatus() { return status; }
        public List<StavkaKosarice> VratiStavke() { return stavke; }
        //iznos kosarice
        public decimal VratiVrijednost()
        {
            decimal ukupno = 0;
            foreach (StavkaKosarice s in stavke)
            {
                ukupno += s.VratiVrijednosti();
            }
            return ukupno;
        }
        //Metode za manipuliranje
        public void DodajStavku(StavkaKosarice s) {
            if (status !=StatusKosarice.Placena && status!= StatusKosarice.Stornirana)
            {
                stavke.Add(s); status = StatusKosarice.Aktivna;
            }
            else
            {
                throw new Exception();
            }
        }
        public void Plati() { status = StatusKosarice.Placena; }
        public void Storniraj() { status = StatusKosarice.Stornirana; }
        //obrisi jednu stavku
        public void ObrisiStavku(StavkaKosarice s) { stavke.Remove(s); }
        //obrisi stavke
        public void Obrisi() { stavke.Clear(); }

        private bool Zasticena()
        {
            return status == StatusKosarice.Placena || status == StatusKosarice.Stornirana;
        }



    }
}
