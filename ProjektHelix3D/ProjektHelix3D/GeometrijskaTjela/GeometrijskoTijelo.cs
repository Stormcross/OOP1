using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HelixToolkit.Wpf;
using System.Windows.Media.Media3D;

namespace ProjektHelix3D.GeometrijskaTjela
{
    class GeometrijskoTijelo
    {
        //zajednicke stvari
        //protected Point3D startPoint;
        //protected Point3D endPoint;



        public virtual void Nacrtaj(HelixViewport3D hv3d) { }

        public enum Koraci
        {
            Nedifiniran,
            Centar,
            Sirina,
            Duzina,
            Visina,
            Definiran
        };

        public Koraci korak { get; set; } = Koraci.Nedifiniran;

        public virtual Point3D Centar { get; set; }
        public virtual double Sirina { get; set; }
        public virtual double Duzina { get; set; }
        public virtual double Visina { get; set; }
    }
}
