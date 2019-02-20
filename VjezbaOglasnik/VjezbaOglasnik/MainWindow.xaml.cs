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

namespace VjezbaOglasnik
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 

    public partial class MainWindow : Window
    {
        //struktura vozila
        public struct Vozilo
        {
            //osnovni podaci o vozilu koje svi imaju
            public string Tip { get; set; }
            public string Proizvodac { get; set; }
            public int GodinaProizvodnje { get; set; }
            public string NovoVozilo { get; set; }
            public bool PrviVlasnik { get; set; }

            //podaci dodatne opreme sto moze varirati od vozila do vozila
            private string oprema;
            public string Oprema
            {
                get
                {
                    return oprema;
                }
                set
                {
                    oprema = value;
                }
            }
        }

        //lista proizvodaca
        private string[] proizvodjaci = new string[] { "Audi", "BMW", "Mercedes", "Citroen", "Peugot", "Fiat", "peugot", "Seat" };

        //lista dodatne opreme
        private string[] dodatnaOprema = new string[] { "Klima", "ABS", "Elektro paket", "Grijani retrovizori", "Alu felge", "Ostalo" };

        //javna lista oglasa
        public List<Vozilo> oglasi = new List<Vozilo>();

        //lista godina
        public List<int> VratiListuGodina(int odGodine, int doGodine)
        {
            List<int> godine = new List<int>();
            for (int i = odGodine; i < doGodine; i++)
            {
                godine.Add(i);
            }
            return godine;

        }

        //konstruktor

        public MainWindow()
        {
            InitializeComponent();

            //vezivanje polja proizvodaci na ComboBox
            proizvodacListBox.ItemsSource = proizvodjaci;

            //punimo godinu proizvodnje
            godinaProizvodnjeComboBox.ItemsSource = VratiListuGodina(1950, DateTime.Now.Year);

            //oprema
            opremaListBox.ItemsSource = dodatnaOprema;
        }

        private void posaljiButton_Click(object sender, RoutedEventArgs e)
        {
            Vozilo v = new Vozilo();

            //Tip vozila
            v.Tip = tipTextBox.Text;

            //prozvodac, godina proizvodnje
            //x ? y : z -> cita se ako je x onda y inace z
            v.Proizvodac = proizvodacListBox.SelectedItem != null ?
                proizvodacListBox.SelectedItem.ToString() : "";

            v.GodinaProizvodnje = godinaProizvodnjeComboBox.SelectedItem != null ?
                int.Parse(godinaProizvodnjeComboBox.SelectedItem.ToString()) : 0;

            //Radio Button radnje
            if ((bool)novoRadioButton.IsChecked)
            {
                v.NovoVozilo = "Novo";
            }
            else if ((bool)koristenoRadioButton.IsChecked)
            {
                v.NovoVozilo = "Koristeno";
            }
            else
            {
                v.NovoVozilo = "Nedefinirano";
            }

            //Check Box
            v.PrviVlasnik = (bool)prviVlasnikCheckBox.IsChecked;

            //Dodatna oprema
            v.Oprema = "";
            foreach (var _oprema in opremaListBox.SelectedItems)
            {
                v.Oprema += _oprema.ToString() + ", ";
            }

            //dodajemo na listu
            oglasi.Add(v);

            //punimo Data Grid
            listaDataGrid.ItemsSource = oglasi;
            listaDataGrid.Items.Refresh();

        }

        private void izlazButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
