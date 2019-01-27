using HelixToolkit.Wpf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Media3D;

namespace ProjektHelix3D.GeometrijskaTjela
{
    class Kugla:GeometrijskoTijelo
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
                return objekt.Radius  ;
            }
            set
            {
                objekt.Radius = value;
            }
        }
        public override double Sirina
        {
            get
            {
                return objekt.Radius;
            }
            set
            {
                objekt.Radius = value;
            }
        }
        public override double Visina
        {
            get
            {
                return objekt.Radius;
            }
            set
            {
                objekt.Radius = value;
            }
        }

        private SphereVisual3D objekt = new SphereVisual3D();
        public Kugla()
        {
            Duzina = 0.005;
            Sirina = 0.005;
            Visina = 0.005;
        }
        public Kugla(double duzina)
        {


            //double[] test = new double[] { (double)kvadrat.Length, (double)kvadrat.Width, (double)kvadrat.Height };
            //double max = test.Max();

            this.Duzina = duzina;
            this.Visina = duzina;
            this.Sirina = duzina;

            objekt.Radius = Duzina;
            objekt.Radius = Visina;
            objekt.Radius = Sirina;


        }
        public override void Nacrtaj(HelixViewport3D hVp3D)
        {
            hVp3D.Items.Add(objekt);
        }
    }
}
