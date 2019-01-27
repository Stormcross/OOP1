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
    abstract class GeometrijskoTijelo
    {
        //zajednicke stvari
        //protected Point3D startPoint; //pocetna tocka
        //protected Point3D endPoint; //zavrsna tocka
        //protected GeometryModel3D oblik; //oblik koji postavljamo
        //private Color boja = new Color();
        //protected Material materijal=new DiffuseMaterial(); //boja ispune
        //protected HelixViewport3D hv3d; //podloga na kojoj radimo

        public abstract void Nacrtaj(HelixViewport3D hVp3D);

        public enum Koraci
        {
            Nedifiniran,
            Centar,
            Sirina,
            Duzina,
            Visina,
            Definiran
        }; //za sad jedini nacin

        //public void Postavi(Point3D pocetak, Point3D kraj, HelixViewport3D podloga)
        //{
        //    startPoint = pocetak;
        //    endPoint = kraj;
        //    //materijal = bojaIspune;
        //    hv3d = podloga;
        //}


        //metoda za prikaz na podlogi
        //public virtual void Nacrtaj()
        //{
        //    //ako oblik koji crtamo nije na podlogi prvo ga dodaj
        //    if (hv3d.Items.Contains(oblik))
        //    {
        //        hv3d.Items.Add(oblik); //oblik dodajemo na internu listu objekata
        //    }
        //    //oblik.Material = boja;
        //}

        public Koraci korak { get; set; } = Koraci.Nedifiniran;

        public abstract Point3D Centar { get; set; }
        public abstract double Sirina { get; set; }
        public abstract double Duzina { get; set; }
        public abstract double Visina { get; set; }
    }
}
