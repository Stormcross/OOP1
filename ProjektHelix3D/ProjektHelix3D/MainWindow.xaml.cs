using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using HelixToolkit.Wpf;
using System.Windows.Media.Media3D;
using ProjektHelix3D.Enumeracije;
using ProjektHelix3D.GeometrijskaTjela;
using Xceed.Wpf.Toolkit;

namespace ProjektHelix3D
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// // Ikone: https://www.microsoft.com/en-us/download/details.aspx?id=35825
    /// </summary>
    public partial class MainWindow : Window
    {
        //globalne varijable
        private Operacije operacija = Operacije.Pokazivac;
        private Point3D startPoint3D;
        private Point3D endPoint3D;
        //koordinate
        private double x, y, z;
        private GeometrijskoTijelo oblik;

        public MainWindow()
        {
            InitializeComponent();
            //postavke za pregled kamere,svjetla i grid za rad
            viewPort3D.DefaultCamera = new PerspectiveCamera(); //uzimamo kameru iz System.Windows.Media.Media3D;
            viewPort3D.DefaultCamera.Position = new Point3D(0, 0, 10); //postavljamo poziciju kamer eu prostoru
            viewPort3D.DefaultCamera.LookDirection = new Vector3D(-1, 1, 0); //kordinate nagiba kamere
            viewPort3D.DefaultCamera.UpDirection = new Vector3D(0, 0, 1); //pokazuje gdje je gornji dio kamere
            viewPort3D.ShowFrameRate = true; //da vidimo framerate na kojem nam radi program
            viewPort3D.ShowCoordinateSystem = true; //pokazuje nam koordinatne osi
            viewPort3D.CalculateCursorPosition = true;
            DefaultLights lights = new DefaultLights(); //inicijaliziramo objekt svjetla
            viewPort3D.Children.Add(lights); //dodajemo svjetla na internu listu viewPort3D
            GridLinesVisual3D grid = new GridLinesVisual3D(); //izradimo plocu za crtanje
            grid.Center = new Point3D(0, 0, 0); //pozicioniramo ju na 0 kao referencu
            viewPort3D.Children.Add(grid); //dodajemo je na viewport

            


        }

        //buttons
        private void buttonPokazivac_Click(object sender, RoutedEventArgs e)
        {
            operacija = Operacije.Pokazivac;
        }

        private void buttonKvadar_Click(object sender, RoutedEventArgs e)
        {
            operacija = Operacije.CrtajKvadar;
        }

        private void buttonkvadrat_Click(object sender, RoutedEventArgs e)
        {
            operacija = Operacije.CrtajKvadrat;
        }

        private void buttonSfera_Click(object sender, RoutedEventArgs e)
        {
            operacija = Operacije.CrtajKuglu;
        }

        // krecemo mis po podlogi
        private void viewPort3D_MouseMove(object sender, MouseEventArgs e)
        {
            //ispisivanje kordinata kraj misa
            base.OnMouseMove(e);
            endPoint3D.X = ((Point3D)viewPort3D.CursorPosition).X;
            endPoint3D.Y = ((Point3D)viewPort3D.CursorPosition).Y;
            endPoint3D.Z = ((Point3D)viewPort3D.CursorPosition).Z;
            pozicijaX.Text = String.Format(
                "X = {0:0.000}\n" +
                "Y = {1:0.000}\n" +
                "Z = {2:0.000}",
                endPoint3D.X, endPoint3D.Y, endPoint3D.Z);
            if (oblik != null)
            {
                switch (oblik.korak)
                {
                    case GeometrijskoTijelo.Koraci.Duzina:
                        oblik.Duzina = oblik.Centar.Y - ((Point3D)viewPort3D.CursorPosition).Y;
                        break;
                    case GeometrijskoTijelo.Koraci.Sirina:
                        oblik.Sirina = oblik.Centar.X - ((Point3D)viewPort3D.CursorPosition).X;
                        break;
                    case GeometrijskoTijelo.Koraci.Visina:
                        oblik.Visina = oblik.Centar.Z - ((Point3D)viewPort3D.CursorPosition).Z;
                        break;
                }

            }
        }

        //radnje na ploci
        //pritisak na lijevu tipku misa
        private void viewPort3D_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            
            if (oblik == null)
            {
                try
                {
                    oblik = KreatorOblika.Vrati(operacija);
                }
                catch (Exception ex)
                {
                    System.Windows.MessageBox.Show("Dogodila se greska:" + ex.Message);
                }

                if (operacija != Operacije.Pokazivac)
                {
                    oblik.korak = GeometrijskoTijelo.Koraci.Centar;
                    oblik.Centar = (Point3D)viewPort3D.CursorPosition;
                    oblik.Nacrtaj(viewPort3D);
                    oblik.korak = GeometrijskoTijelo.Koraci.Duzina;
                }

            }
            else if(oblik.GetType()==typeof(Kvadar))
            {

                switch (oblik.korak)
                {
                    case GeometrijskoTijelo.Koraci.Duzina:
                        oblik.korak = GeometrijskoTijelo.Koraci.Sirina;
                        break;
                    case GeometrijskoTijelo.Koraci.Sirina:
                        oblik.korak = GeometrijskoTijelo.Koraci.Visina;
                        break;
                    case GeometrijskoTijelo.Koraci.Visina:
                        oblik.korak = GeometrijskoTijelo.Koraci.Definiran;
                        oblik = null;
                        break;
                }
            }
            else
            {
                oblik.korak = GeometrijskoTijelo.Koraci.Definiran;
                oblik = null;
            }
        }
        //pustimo lijevu tipku
        private void viewPort3D_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            //operacija = Operacije.Pokazivac;
            //oblik = null;
        }




    }
}
