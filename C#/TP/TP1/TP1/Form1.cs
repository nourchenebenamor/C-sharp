using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP1
{
    public partial class Form1 : Form
    {
        private Grille grille;
        private IDessinateur dr;
        private int _taille = 40;
        public Form1()
        {
            InitializeComponent();

            grille = new Grille(6, 6, 5);

            dr = new Drawer1(_taille);

            this.DoubleBuffered = true;

            label1.Text= grille.ToString();


        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            dr.Dessine(grille, e.Graphics);
        }
    }
}
