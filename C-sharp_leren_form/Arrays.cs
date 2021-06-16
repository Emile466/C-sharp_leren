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
    public partial class frmArrays : Form
    {
        string[] arrIngrediënten = { "Appel", "Peer", "Meloen", "Aardbei", "Framboos", "Rode bes" };
        public frmArrays()
        {
            InitializeComponent();
        }

        private void frmArrays_Load(object sender, EventArgs e)
        {
            fillLivIngrediënten(); // ListView meteen opvullen wanneer form wordt geladen
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void fillLivIngrediënten()
        {
            livIngrediënten.Items.Clear();
            foreach (var ingrediënt in arrIngrediënten)
            {
                ListViewItem livIngrediëntenItem = new ListViewItem(ingrediënt); // Eerst een listViewItem maken van een item in een array
                livIngrediënten.Items.Add(livIngrediëntenItem); // Listview op form vullen met juist gemaakte items
            }
        }
    }
}
