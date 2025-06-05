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
    public partial class GameForm : Form
    {
        public GameForm()
        {
            InitializeComponent();
        }

        private void retour_main(object sender, EventArgs e)
        {
            Form1 menu = new Form1(); // crée la nouvelle page
            menu.Show(); // l'affiche
            this.Hide();
        }

        private void GameForm_Load(object sender, EventArgs e)
        {
            CreateChessBoard();
            this.Width = 600;
            this.Height = 600;
            this.StartPosition = FormStartPosition.CenterScreen;

        }
        private Button[,] boardButtons = new Button[8, 8];
        private void CreateChessBoard()
        {
            int tileSize = 60; // taille des cases
            int offsetX = 50;  // marge à gauche
            int offsetY = 50;  // marge en haut

            for (int row = 0; row < 8; row++)
            {
                for (int col = 0; col < 8; col++)
                {
                    Button btn = new Button();
                    btn.Width = tileSize;
                    btn.Height = tileSize;
                    btn.Left = offsetX + col * tileSize;
                    btn.Top = offsetY + row * tileSize;



                    // Couleur alternée
                    btn.BackColor = (row + col) % 2 == 0 ? Color.MediumAquamarine : Color.HotPink;

                    //btn.Tag = new Point(row, col); // pour identifier la case
                    //btn.Click += Square_Click;

                    this.Controls.Add(btn);
                    boardButtons[row, col] = btn;

                    string path = Path.Combine(Application.StartupPath, "images", "white_pawn.png");
                    btn.BackgroundImage = Image.FromFile(path);
                    btn.BackgroundImageLayout = ImageLayout.Stretch;






                }
            }
        }


        /*private void Square_Click(object sender, EventArgs e)
        {
            Button clicked = sender as Button;
            Point pos = (Point)clicked.Tag;
            MessageBox.Show($"Case cliquée : {pos.X}, {pos.Y}");
        }*/

        private void ChessPiece()
        {

        }
    }   
}
