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
using System.Windows.Shapes;

namespace VA_AR
{
    /// <summary>
    /// Interaction logic for VR_Odabir.xaml
    /// </summary>
    public partial class VR_Odabir : Window
    {
        List<InformacijeClass> VR_info = new List<InformacijeClass>();

        public VR_Odabir()
        {
            InitializeComponent();

            //pokrenemo metode da upisu u listu
            HTC_Vive();
            Oculus_Rift();
            Oculus_GO();
            Sony_Playstation_VR();
            Samsung_Gear_VR();
            HTC_Vive_Pro();
            Lenovo_Mirage();

        }


        
        public  List<string> ObjekPremaIndexu(int index)
        {
            InformacijeClass obIspisa = new InformacijeClass();
            
            obIspisa = VR_info[index];

            List<string> parametriObjekta = new List<string>()
            {
                obIspisa.Ime,
                obIspisa.TipHeadseta,
                obIspisa.TipUSB,
                obIspisa.Rezolucija,
                obIspisa.RefreshRate,
                obIspisa.Senzori,
                obIspisa.Kontroleri,
                obIspisa.PlatformaHardware,
                obIspisa.PlatformaSoftware,
                obIspisa.Cijena
            };

            return parametriObjekta;
        }

        private void HTC_Vive()
        {
            InformacijeClass obHTCvive = new InformacijeClass();

            obHTCvive.Ime = "HTC Vive";
            obHTCvive.TipHeadseta = "Tethered";
            obHTCvive.TipUSB = "HDMI, USB 3.0";
            obHTCvive.Rezolucija = "1080 x 1200 per eye";
            obHTCvive.RefreshRate = "90 Hz";
            obHTCvive.Senzori = "Motion, camera, extrnal motion tracking";
            obHTCvive.Kontroleri = " HTC Vive motion controlers";
            obHTCvive.PlatformaHardware = "PC";
            obHTCvive.PlatformaSoftware = "SteamVR";
            obHTCvive.Cijena = "499";

            VR_info.Add(obHTCvive);

            
        }

        private void Oculus_Rift()
        {
            InformacijeClass obOculusRift = new InformacijeClass();

            obOculusRift.Ime = "Oculus Rift";
            obOculusRift.TipHeadseta = "Tethered";
            obOculusRift.TipUSB = "USB 3.0";
            obOculusRift.Rezolucija = "1080 x 1200 per eye";
            obOculusRift.RefreshRate = "90 Hz";
            obOculusRift.Senzori = "Motion, camera, external visual positioning ";
            obOculusRift.Kontroleri = "Oculus Touch, Xbox One gamepad";
            obOculusRift.PlatformaHardware = "PC";
            obOculusRift.PlatformaSoftware = "Oculus";
            obOculusRift.Cijena = "399";

            VR_info.Add(obOculusRift);

        }

        private void Sony_Playstation_VR()
        {
            InformacijeClass obSonyPsVR = new InformacijeClass();

            obSonyPsVR.Ime = "Sony Playastation VR";
            obSonyPsVR.TipHeadseta = "Tethered";
            obSonyPsVR.TipUSB = "HDMI, USB 2.0";
            obSonyPsVR.Rezolucija = "960 x 1080 per eye";
            obSonyPsVR.RefreshRate = "120 Hz";
            obSonyPsVR.Senzori = "Motion, camera, extrnal motion tracking";
            obSonyPsVR.Kontroleri = "DualShock 4, PlayStation Move ";
            obSonyPsVR.PlatformaHardware = "PlayStation 4  ";
            obSonyPsVR.PlatformaSoftware = "SteamVR";
            obSonyPsVR.Cijena = "240";

            VR_info.Add(obSonyPsVR);

        }

        private void Oculus_GO()
        {
            InformacijeClass obOculusGo = new InformacijeClass();

            obOculusGo.Ime = "Sony Playastation VR";
            obOculusGo.TipHeadseta = "Standalone";
            obOculusGo.TipUSB = "None";
            obOculusGo.Rezolucija = "1280 by 1440 per eye ";
            obOculusGo.RefreshRate = "60, 72  Hz";
            obOculusGo.Senzori = "Accelerometer, gyroscope";
            obOculusGo.Kontroleri = "Oculus Go Controller 	 ";
            obOculusGo.PlatformaHardware = "Oculus Go";
            obOculusGo.PlatformaSoftware = "Android";
            obOculusGo.Cijena = "199";

            VR_info.Add(obOculusGo);

        }

        private void Samsung_Gear_VR()
        {
            InformacijeClass obSamsungGear = new InformacijeClass();

            obSamsungGear.Ime = "Sony Playastation VR";
            obSamsungGear.TipHeadseta = "Mobile";
            obSamsungGear.TipUSB = "USB 2.0, USB 3.0";
            obSamsungGear.Rezolucija = " Native to phone ";
            obSamsungGear.RefreshRate = " Native to phone ";
            obSamsungGear.Senzori = "Motion";
            obSamsungGear.Kontroleri = "Handheld remote, touchpad on headset";
            obSamsungGear.PlatformaHardware = "Samsung Gear VR powered by Oculus";
            obSamsungGear.PlatformaSoftware = "Android";
            obSamsungGear.Cijena = "129.99";

            VR_info.Add(obSamsungGear);

        }

        private void HTC_Vive_Pro()
        {
            InformacijeClass obHTCvivePro = new InformacijeClass();

            obHTCvivePro.Ime = "HTC Vive Pro";
            obHTCvivePro.TipHeadseta = "Tethered";
            obHTCvivePro.TipUSB = "Display Port, USB 3.0";
            obHTCvivePro.Rezolucija = "1440 by 1600 per eye";
            obHTCvivePro.RefreshRate = "90 Hz";
            obHTCvivePro.Senzori = "Motion, camera, extrnal motion tracking";
            obHTCvivePro.Kontroleri = " HTC Vive motion controlers";
            obHTCvivePro.PlatformaHardware = "PC";
            obHTCvivePro.PlatformaSoftware = "SteamVR";
            obHTCvivePro.Cijena = "812";

            VR_info.Add(obHTCvivePro);

        }

        private void Lenovo_Mirage()
        {
            InformacijeClass obHTCvivePro = new InformacijeClass();

            obHTCvivePro.Ime = "Lenovo Mirage Solo With Daydream";
            obHTCvivePro.TipHeadseta = "Standalone";
            obHTCvivePro.TipUSB = "None";
            obHTCvivePro.Rezolucija = "1280 x 1440 ";
            obHTCvivePro.RefreshRate = "75 Hz";
            obHTCvivePro.Senzori = "Gyroscope, accelerometer, magnetometer, dual tracking cameras ";
            obHTCvivePro.Kontroleri = "Daydream Controller ";
            obHTCvivePro.PlatformaHardware = "Android";
            obHTCvivePro.PlatformaSoftware = "Google Daydream";
            obHTCvivePro.Cijena = "812";

            VR_info.Add(obHTCvivePro);

        }

        public int IndexOdabrano = 0;

        private void buttonHtcVive_Click(object sender, RoutedEventArgs e)
        {
            //index po kojem nademo parametre
            IndexOdabrano = 0;


            foreach (var item in ObjekPremaIndexu(IndexOdabrano))
            {
                Console.WriteLine(item);
            }

            VR_odabrano vR_Odabrano = new VR_odabrano();
            vR_Odabrano.Show();

        }

        private void buttonOculusRift_Click(object sender, RoutedEventArgs e)
        {
            //index po kojem nademo parametre
            IndexOdabrano = 1;


            foreach (var item in ObjekPremaIndexu(IndexOdabrano))
            {
                Console.WriteLine(item);
            }

            VR_odabrano vR_Odabrano = new VR_odabrano();
            vR_Odabrano.Show();
        }

        private void buttonPSvr_Click(object sender, RoutedEventArgs e)
        {
            //index po kojem nademo parametre
            IndexOdabrano = 2;


            foreach (var item in ObjekPremaIndexu(IndexOdabrano))
            {
                Console.WriteLine(item);
            }

            VR_odabrano vR_Odabrano = new VR_odabrano();
            vR_Odabrano.Show();
        }
    }
}
