using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_sharp_leren_form
{
    public partial class Cirkel_rechthoek_classes : Form
    {
        int straal; // publieke variabele binnen form
        int lengte, breedte;
        Color kleur = Color.Blue;
        int lijndikte = 1;
        Point middelpunt = new Point(0, 0);

        public Cirkel_rechthoek_classes()
        {
            InitializeComponent();
        }

        private void btnCirkel_Click(object sender, EventArgs e)
        {
            Cirkel cirkel = new Cirkel(straal, this, kleur, lijndikte, middelpunt);
            lblOmtrekCirkel.Text = "Omtrek : " + cirkel.Omtrek().ToString("0.00");
            lblOppervlakteCirkel.Text = "Oppervlakte : " + cirkel.Oppervlak().ToString("0.00");
            cirkel.Teken();
        }

        private void btnRechthoek_Click(object sender, EventArgs e)
        {
            Rechthoek rechthoek = new Rechthoek(lengte,breedte, this, lijndikte, kleur, middelpunt);
            lblOmtrekRechthoek.Text = "Omtrek : " + rechthoek.Omtrek().ToString("0.00");
            lblOppervlakteRechthoek.Text = "Oppervlakte : " + rechthoek.Oppervlakte().ToString("0.00");
            if (chkColor.Checked)
            {
                colorDialog1.ShowDialog();
                kleur = colorDialog1.Color;
                ColorDialog colorDialog = new ColorDialog();
            }
            rechthoek.Teken();
        }

        private void txbStraalCirkel_TextChanged(object sender, EventArgs e) //wanneer text wordt ingevoerd
        {
            if (int.TryParse(txbStraalCirkel.Text, out straal))
                straal = int.Parse(txbStraalCirkel.Text);
            else
                txbStraalCirkel.Clear();
        }

        private void txbLengteRechthoek_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(txbLengteRechthoek.Text, out lengte))
                lengte = int.Parse(txbLengteRechthoek.Text);
            else
                txbLengteRechthoek.Clear();
        }

        private void btnKleur_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            kleur = colorDialog1.Color;
            ColorDialog colorDialog = new ColorDialog();
        }

        private void txbLijndikte_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(txbLijndikte.Text, out lijndikte))
                lijndikte = int.Parse(txbLijndikte.Text);
            else
                txbLijndikte.Clear();
        }

        private void Cirkel_rechthoek_classes_MouseClick(object sender, MouseEventArgs e)
        {
            middelpunt = e.Location;
        }

        private void Cirkel_rechthoek_classes_Load(object sender, EventArgs e)
        {

        }

        private void txbBreedteRechthoek_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(txbBreedteRechthoek.Text, out breedte))
                breedte = int.Parse(txbBreedteRechthoek.Text);
            else
                txbBreedteRechthoek.Clear();
        }
    }
}
