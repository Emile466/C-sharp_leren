using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_sharp_leren_form
{
    public partial class Form_oefenen : Form
    {
        public Form_oefenen()
        {
            InitializeComponent();
        }

        private void FormOefenen_MouseClick(object sender, MouseEventArgs e)
        {
            lblX.Text = "X " + e.X.ToString();
            lblY.Text = "Y " + e.Y.ToString();
         }

        private void txbInput_KeyPress(object sender, KeyPressEventArgs e)
        {
//            txbOutput.Text += ((char)e.KeyChar).ToString() + "\r\n"; // ASCII teken
              txbOutput.Text += ((int)e.KeyChar).ToString() + "\r\n";  //ASCII nummer
        }

        private void Form_oefenen_Load(object sender, EventArgs e)
        {
            // Welkom bezoeker methode
            MessageBox.Show(WelkomBezoeker(Environment.UserDomainName));
            string WelkomBezoeker (string strNaamGebruiker)
            {
                return "Hallo daar " + strNaamGebruiker;
            }
        }

        private void btnBerekenOmtrek_Click(object sender, EventArgs e)
        {
            // Bereken omtrek van rechthoek
            txbOmtrekRechthoek.Text = BerekenOmtrekRechthoek(double.Parse(txbLengteRechthoek.Text), double.Parse(txbBreedteRechthoek.Text)).ToString();
            double BerekenOmtrekRechthoek (double dblLengte, double dblBreedte)
            {
                return ((dblLengte + dblBreedte) * 2);
            }
        }

        private void btnTelLetters_Click(object sender, EventArgs e)
        {
            // Letters tellen
            List<string> lstLetters = new List<string>();
            string strLettersTextbox = txbLettersTellen.Text;
            foreach (var item in strLettersTextbox) // kan ook per woord met strLettersTextBox.Split(' ')
            {
                lstLetters.Add(item.ToString()); 
            }
            int intAantalKlinkers, intAantalMedeklinkers, intAantalSpaties;
            intAantalKlinkers = intAantalMedeklinkers = intAantalSpaties = 0;
            foreach (var item in lstLetters)
            {
                var regexItem = new Regex("^[a-zA-Z]*$"); // niet zelf gemaakt
                if (!regexItem.IsMatch(item))
                    continue;

                if (item.Contains("a") || item.Contains("e") || item.Contains("u") || item.Contains("i") || item.Contains("o"))
                {
                    intAantalKlinkers += 1;
                }
                else if (item.Contains(" "))
                {
                    intAantalSpaties += 1;
                }

                else
                intAantalMedeklinkers += 1;
                
            }
            lblAantalKlinkers.Text = "# klinkers " + intAantalKlinkers.ToString();
            lblAantalMedeklinkers.Text = "# medeklinkers " + intAantalMedeklinkers.ToString();
            lblAantalSpaties.Text = "# spaties " + intAantalSpaties.ToString();
        }
    }
}
