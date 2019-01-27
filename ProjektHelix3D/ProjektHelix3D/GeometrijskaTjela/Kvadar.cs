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
        private BoxVisual3D kvadar = new BoxVisual3D();
        //postavimo sve sto je u baznoj klazi zadano
        //Get-Set
        public override Point3D Centar
        {
            get
            {
                return kvadar.Center;
            }

            set
            {
                kvadar.Center = value;
            }
        }
        public override double Duzina
        {
            get
            {
                return kvadar.Width;
            }
            set
            {
                kvadar.Width = value;
            }
        }
        public override double Sirina
        {
            get
            {
                return kvadar.Length;
            }
            set
            {
                kvadar.Length = value;
            }
        }
        public override double Visina
        {
            get
            {
                return kvadar.Height;
            }
            set
            {
                kvadar.Height= value;
            }
        }

        private BoxVisual3D GetKvadar()
        {
            return kvadar;
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

            //kvadar.Length = Duzina;
            //kvadar.Height = Visina;
            //kvadar.Width = Sirina;
        }




    }
}
