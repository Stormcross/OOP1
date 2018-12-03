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
            this.polumjer = polumjer;
        }

        public double Polumjer //1.4
        {
            get { return this.polumjer; }
            set { this.polumjer = value; }
        }

        public Kugla(double polumjer)
        {
            this.polumjer = polumjer;
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
            return String.Format("Polumjer: {0} Volumen: {1} Oplosje: {2}",polumjer,Volumen(),Oplosje());
        } //1.9



           





        //Kraj klase
    }
}
