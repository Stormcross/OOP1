using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Media3D;
using HelixToolkit.Wpf;

namespace ProjektHelix3D.GeometrijskaTjela
{
    class Kvadrat : GeometrijskoTijelo
    {

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
                return objekt.SideLength;
            }
            set
            {
                objekt.SideLength = value;
            }
        }
        public override double Sirina
        {
            get
            {
                return objekt.SideLength;
            }
            set
            {
                objekt.SideLength = value;
            }
        }
        public override double Visina
        {
            get
            {
                return objekt.SideLength;
            }
            set
            {
                objekt.SideLength = value;
            }
        }

        private CubeVisual3D objekt = new CubeVisual3D();
        public Kvadrat()
        {
            Duzina = 0.01;
            Sirina = 0.01;
            Visina = 0.01;
        }
        public Kvadrat(double duzina)
        {


            //double[] test = new double[] { (double)kvadrat.Length, (double)kvadrat.Width, (double)kvadrat.Height };
            //double max = test.Max();

            this.Duzina = duzina;
            this.Visina = duzina;
            this.Sirina = duzina;

            objekt.SideLength = Duzina;
            objekt.SideLength = Visina;
            objekt.SideLength = Sirina;


        }
        public override void Nacrtaj(HelixViewport3D hVp3D)
        {
            hVp3D.Items.Add(objekt);
        }
    }
}
