using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valjak_skladiste_kamion.Razred
{
    class Valjak
    {
        private double polumjer;
        private double visina;
        //konstruktori
        public Valjak()
        {
            polumjer = 1;
            visina = 1;
        }
        public Valjak(double polumjer, double visina)
        {
            this.polumjer = polumjer;
            this.visina = visina;
        }
        //set
        public void PostaviPolumjer(double polumjer) { this.polumjer = polumjer; }
        public void PostaviVisinu(double visina) { this.visina = visina; }
        //get
        public double DohvatiPolumejr() { return polumjer; }
        public double DohvatiVisinu() { return visina; }
        //svojstva
        public double PolumjerBaze
        {
            get
            {
                return polumjer;
            }
            set
            {
                this.polumjer = value;
            }
        }
        public double Visina
        {
            get
            {
                return visina;
            }
            set
            {
                this.polumjer = value;
            }
        }
        //Ostale metode
        public double PovrsinaBaze() { return Math.Pow(polumjer, 2) * Math.PI; }
        public double PovrsinaPlasta() { return 2 * polumjer * Math.PI * (polumjer + visina); }
        public double UkupnaPovrsina() { return 2 * PovrsinaBaze() + PovrsinaPlasta(); }
        public double Volumen() { return PovrsinaBaze() * visina; }
        public string toString()
        {
            return String.Format("Plumjer: {0,-4:} Visina: {1,-4} " +
            "\nPovrsina baze:{2:0.00} Povrsina plasta:{3:0.00} Ukupna povrsina:{4:0.00} " +
            "\nVolumen: {5:0.00}",
            polumjer, visina, PovrsinaBaze(), PovrsinaPlasta(), UkupnaPovrsina(), Volumen());
        }

    }
}
