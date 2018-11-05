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

namespace VA_AR
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MessageBox.Show("Da bi aplikacija pravilno radila potrebno je imati internet konekciju!");


        }

        private void buttonVR_Click(object sender, RoutedEventArgs e)
        {
            VR_Odabir vR_Odabir = new VR_Odabir();
            vR_Odabir.Show();
        }
    }
}
