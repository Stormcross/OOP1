using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pismeni_Ispit_2017_07_13
{
    class Kugla
    {
        private double polumjer; //1.1

        public double DovatiPolumjer() //1.2
        {
            return polumjer;
        }

        public void PostaviPolumjer(double polumjer) //1.3
        {
            this.polumjer = ProvjeraPolumjera(polumjer);
        }

        public double Polumjer //1.4
        {
            get { return this.polumjer; }
            set { this.polumjer = value; }
        }

        public Kugla(double polumjer)
        {
            this.polumjer = ProvjeraPolumjera(polumjer);
        } //1.5,6

        public double Volumen()
        {
            return ((4 / 3) * Math.Pow(polumjer, 2) * Math.PI);
        } //1.7

        public double Oplosje()
        {
            return 4 * Math.Pow(polumjer, 2) * Math.PI;
        } //1.8

        public string ToString()
        {
            return String.Format("Polumjer: {0} Volumen: {1} Oplosje: {2}", polumjer, Volumen(), Oplosje());
        } //1.9

        private double ProvjeraPolumjera(double polumjer)
        {
            if (polumjer < 0)
            {
                throw new ArgumentOutOfRangeException("Polumjer", "Polumjer ne moze biti manji od 0");
            }
            else
            {
                return polumjer;
            }
        } //2.1.1

               
        //Kraj klase
    }

    
    public struct SpremljeniPodaciKugla
    {
        Kugla k1,k2,k3,k4,k5;

        List<Kugla> lista;

        public void KugleUStrukturi()
        {
            k1 = new Kugla(2); lista.Add(k1);
            k2 = new Kugla(4); lista.Add(k2);
            k3 = new Kugla(1); lista.Add(k3);
            k4 = new Kugla(5); lista.Add(k4);
            k5 = new Kugla(10); lista.Add(k5);
        }
        


        
    }


}
