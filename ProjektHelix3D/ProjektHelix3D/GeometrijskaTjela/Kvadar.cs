using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Media3D;
using HelixToolkit.Wpf;

namespace ProjektHelix3D.GeometrijskaTjela
{
    class Kvadar : GeometrijskoTijelo
    {
        private BoxVisual3D objekt = new BoxVisual3D();
        //postavimo sve sto je u baznoj klazi zadano
        //Get-Set
        public override Point3D Centar
        {
            get
            {
                return objekt.Center;
            }

            set
            {
                objekt.Center = value;
            }
        }
        public override double Duzina
        {
            get
            {
                return objekt.Width;
            }
            set
            {
                objekt.Width = value;
            }
        }
        public override double Sirina
        {
            get
            {
                return objekt.Length;
            }
            set
            {
                objekt.Length = value;
            }
        }
        public override double Visina
        {
            get
            {
                return objekt.Height;
            }
            set
            {
                objekt.Height= value;
            }
        }

        private BoxVisual3D GetKvadar()
        {
            return objekt;
        }

        //Konstruktori
        public Kvadar() //podrazumjevani konstruktor
        {
            Duzina = 0.005;
            Sirina = 0.005;
            Visina = 0.005;
        }

        public Kvadar(double Duzina, double Sirina, double Visina) //zadani konstruktor
        {
            this.Duzina = Duzina;
            this.Sirina = Sirina;
            this.Visina = Visina;

            objekt.Length = Duzina;
            objekt.Height = Visina;
            objekt.Width = Sirina;
        }

        public override void Nacrtaj(HelixViewport3D hVp3D)
        {
            hVp3D.Items.Add(objekt);
        }




    }
}
