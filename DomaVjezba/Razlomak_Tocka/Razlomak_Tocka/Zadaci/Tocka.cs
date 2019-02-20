using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Razlomak_Tocka.Zadaci
{
    class Tocka
    {
        private float x;
        private float y;
        //konstruktori
        public Tocka()
        {
            x = y = 10;
        }

        public Tocka(float x, float y)
        {
            this.x = x;
            this.y = y;
        }
        //set
        public void SetX(float x) { this.x = x; }
        public void SetY(float y) { this.y = y; }
        public void SetXY(float x, float y) { this.x = x; this.y = y; }
        //get
        public float GetX() { return x; }
        public float GetY() { return y; }
        //apsolutni pomak tocke
        public void ApsolutniPomakXY(Tocka t)
        {
            SetXY(t.x, t.y);
        }
        //relativni pomak tocke
        public void RelativniPomakXY(Tocka t, float x, float y)
        {
            SetXY(t.x + x, t.y + y);
        }
        //udaljenost od tocke
        private double UdaljenostOdTocke(float x, float y)
        {
            return Math.Sqrt(Math.Pow(this.x - x, 2) + Math.Pow(this.y - y, 2));
        }
        public double IzracunUdaljenostTocke(float x, float y)
        {
           return UdaljenostOdTocke(x, y);
        }
        public double IzracunUdaljenostTocke(Tocka t)
        {
            return UdaljenostOdTocke(t.x, t.y);
        }


    }
}
