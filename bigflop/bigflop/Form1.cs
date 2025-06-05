using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bigflop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void load_game(object sender, EventArgs e)
        {
            GameForm gameForm = new GameForm(); // crée la nouvelle page
            gameForm.Show(); // l'affiche
            this.Hide();
        }

        private void load_regle(object sender, EventArgs e)
        {
            Regle regle = new Regle(); // crée la nouvelle page
            regle.Show(); // l'affiche
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string path = Path.Combine(Application.StartupPath, "images", "Background.png");
            this.BackgroundImage = Image.FromFile(path);
            this.BackgroundImageLayout = ImageLayout.Stretch;
            Titre.BackColor = Color.Transparent;


        }
    }
}
