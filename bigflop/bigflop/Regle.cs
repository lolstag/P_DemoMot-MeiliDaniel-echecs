using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bigflop
{
    public partial class Regle : Form
    {
        public Regle()
        {
            InitializeComponent();
        }

        private void retour_main(object sender, EventArgs e)
        {

            Form1 menu = new Form1(); // crée la nouvelle page
            menu.Show(); // l'affiche
            this.Hide();

        }
    }
}
