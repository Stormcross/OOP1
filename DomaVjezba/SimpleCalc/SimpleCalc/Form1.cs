using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//youtube: https://www.youtube.com/watch?v=l68j38ie1_k&t=98s

namespace SimpleCalc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double prviBroj, drugiBroj, rezultat;                   //dodavanje varijabla za izracun

            //
            //postavljanje eventa sto ce se dogoditi na click
            //
            //Mnozenje
        private void buttonMnozenje_Click(object sender, EventArgs e) // event na click
        {

            prviBroj = Convert.ToDouble(textPrviBroj.Text);     //citamo text iz prvog boxa te ga pretvaramo u double po osnovi .text
            drugiBroj = Convert.ToDouble(textDrugiBroj.Text);
            rezultat = prviBroj * drugiBroj;
            textRezultat.Text = rezultat.ToString();            //u .text na boxu rezultat prikazat rezultat u obliku stringa
        }

            //Oduzimanje
        private void buttonOduzimanje_Click(object sender, EventArgs e)
        {
            prviBroj = Convert.ToDouble(textPrviBroj.Text);    
            drugiBroj = Convert.ToDouble(textDrugiBroj.Text);
            rezultat = prviBroj - drugiBroj;
            textRezultat.Text = rezultat.ToString();            
        }

            //Zbrajanje
        private void buttonZbrajanje_Click(object sender, EventArgs e)
        {
            prviBroj = Convert.ToDouble(textPrviBroj.Text);
            drugiBroj = Convert.ToDouble(textDrugiBroj.Text);
            rezultat = prviBroj + drugiBroj;
            textRezultat.Text = rezultat.ToString();

        }

            //Dijeljenje
        private void buttonDijeljenje_Click(object sender, EventArgs e)
        {
            if (Convert.ToDouble(textDrugiBroj.Text)!=0) //provjera ako je podijeljeno s 0
            {
                prviBroj = Convert.ToDouble(textPrviBroj.Text);
                drugiBroj = Convert.ToDouble(textDrugiBroj.Text);
                rezultat = prviBroj / drugiBroj;
                textRezultat.Text = rezultat.ToString();
            }
            else //u slucaju da je, program nece radit nista
            {

            }
        }

        private void textPrviBroj_KeyPress(object sender, KeyPressEventArgs e)  //program zabranjuje unsenje bilo kojeg dijela osim brojeva
        {
            if (char.IsDigit(e.KeyChar) == false && char.IsControl(e.KeyChar) == false && (e.KeyChar == '.' ? textPrviBroj.Text.Contains('.') == true : true)) //uzeto s neta
                e.Handled = true;
        }

        private void textDrugiBroj_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && char.IsControl(e.KeyChar) == false && (e.KeyChar == '.' ? textDrugiBroj.Text.Contains('.') == true : true)) //uzeto s neta
                e.Handled = true;
        }

      


       
        





    }
}
