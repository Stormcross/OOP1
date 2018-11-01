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

namespace K1_Marko
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        List<infoJabuke> informacijeJabuke = new List<infoJabuke>();

        //izbacuje potvrdu da su informacije unesene u listu
        public void potvrda()
        {
            MessageBox.Show("Informacije spremljene!");
        }

        public MainWindow()
        {

            InitializeComponent();

        }

        //unosenje informacija
        private void ButtonZapamtiBroj_Click(object sender, RoutedEventArgs e)
        {
            infoJabuke jabuke = new infoJabuke();

            jabuke.bojaJabuka = textBoxBoja.Text;
            jabuke.kolicinaJabuka = int.Parse(textBoxKolicina.Text);

            informacijeJabuke.Add(jabuke);

            zbrojIsteBoje(); //provijerimo da li su istih boja te ih zbrojimo

            potvrda(); //prozor za potvrdu

            textBoxBoja.Text = null;
            textBoxKolicina.Text = null;

        }

        //ako su unesene jabuke istih boja one se zbroje u jednu cijelinu
        public void zbrojIsteBoje()
        {


            for (int i = 0; i < informacijeJabuke.Count; i++)
            {
                int istihBoja = informacijeJabuke[i].kolicinaJabuka;
                string _bojaJabuke = informacijeJabuke[i].bojaJabuka;
                for (int j = i + 1; j < informacijeJabuke.Count; j++)
                {
                    if (_bojaJabuke == informacijeJabuke[j].bojaJabuka)
                    {
                        istihBoja += informacijeJabuke[j].kolicinaJabuka;
                        informacijeJabuke.RemoveAt(j);
                    }
                }

                informacijeJabuke[i].kolicinaJabuka = istihBoja;

            }


        }

        //ukupna kolicina jabuka
        private void buttonIzracunajKolicinaSvih_Click(object sender, RoutedEventArgs e)
        {
            int ukupno = 0;
            foreach (var jabuka in informacijeJabuke)
            {
                ukupno += jabuka.kolicinaJabuka;
            }
            textBoxZbrojJabuka.Text = ukupno.ToString();
        }

        //pretraga jabuka po boji koja ima najmanju kolicinu unosa
        private void buttonPretrazi_Click(object sender, RoutedEventArgs e)
        {
            int minKolicinaJabuka = informacijeJabuke[0].kolicinaJabuka;
            string bojaNajmanjeJabuka = "";

            foreach (var jabuka in informacijeJabuke)
            {

                if (jabuka.kolicinaJabuka <= minKolicinaJabuka)
                {
                    minKolicinaJabuka = jabuka.kolicinaJabuka;
                    bojaNajmanjeJabuka = jabuka.bojaJabuka;
                }
            }

            textBoxNajmanjeJabuka.Text = bojaNajmanjeJabuka.ToString();
        }
    }
}
