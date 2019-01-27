using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HelixToolkit.Wpf;
using System.Windows.Media.Media3D;
using System.Windows.Media;

namespace ProjektHelix3D.GeometrijskaTjela
{
    class GeometrijskoTijelo
    {
        //zajednicke stvari
        protected Point3D startPoint; //pocetna tocka
        protected Point3D endPoint; //zavrsna tocka
        protected MeshElement3D oblik; //oblik koji postavljamo
        protected Brush boja; //boja ispune
        protected HelixViewport3D hv3d; //podloga na kojoj radimo

        public enum Koraci
        {
            Nedifiniran,
            Centar,
            Sirina,
            Duzina,
            Visina,
            Definiran
        }; //pokusamo ovo izbaciti van

        public void Postavi(Point3D pocetak,Point3D kraj,Brush bojaIspune)
        {
            startPoint = pocetak;
            endPoint = kraj;
            boja = bojaIspune;
        }

        
        //metoda za prikaz na podlogi
        public virtual void Nacrtaj()
        {
            //ako oblik koji crtamo nije na podlogi prvo ga dodaj
            if (hv3d.Children.Contains(oblik))
            {
                hv3d.Children.Add(oblik); //oblik dodajemo na internu listu objekata
            }
            oblik.Fill = boja;
        }

        public Koraci korak { get; set; } = Koraci.Nedifiniran;

        public virtual Point3D Centar { get; set; }
        public virtual double Sirina { get; set; }
        public virtual double Duzina { get; set; }
        public virtual double Visina { get; set; }
    }
}
