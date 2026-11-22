using NSTTris;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP3
{

    public partial class Form1 : Form
    {
        private IPieceT pieceMobile;
        private IPieceT pieceFixe;
        private FabriquePieces fabrique;
        private PieceBridee FabriqueBridee;
        private IDessinateur dessinateur;
        private Tas tas;

        public Form1()
        {
            // InitializeComponent();

            this.Text = "Test Tas";
            this.ClientSize = new Size(300, 350);
            this.DoubleBuffered = true;

            tas = new Tas(8, 10);

            fabrique = new FabriqueSimple();
            pieceMobile = fabrique.CreerPiece();
            pieceMobile.SetLiCo(0, 3);

            dessinateur = new DessinateurTTris(25, 10, 50);

            this.Paint += Form1_Paint;
            MenuStrip menu = new MenuStrip();

            ToolStripMenuItem piece = new ToolStripMenuItem("Pièce");
            ToolStripMenuItem standard = new ToolStripMenuItem("Standard");
            ToolStripMenuItem bridee = new ToolStripMenuItem("Bridée");

            standard.Click += (s, e) =>
            {
                fabrique = new FabriqueSimple();
                standard.Checked = true;
                bridee.Checked = false;
            };

            bridee.Click += (s, e) =>
            {
                fabrique = new FabriqueBridee();
                bridee.Checked = true;
                standard.Checked = false;
            };

            standard.Checked = true;

            piece.DropDownItems.Add(standard);
            piece.DropDownItems.Add(bridee);

            menu.Items.Add(piece);

            this.Controls.Add(menu);
            this.MainMenuStrip = menu;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics gr = e.Graphics;

            // Dessiner le tas
            int[,] tab = new int[10, 8];

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    tab[i, j] = tas.At(i, j);
                }
            }

            PieceT p = new PieceT(tab, 0, 0);
            dessinateur.Dessine(p, gr);

            // Dessiner la pièce mobile
            if (pieceMobile != null)
                dessinateur.Dessine(pieceMobile, gr);
        }

        protected override bool ProcessDialogKey(Keys keyData)
        {
            if (pieceMobile == null)
                return base.ProcessDialogKey(keyData);

            switch (keyData)
            {
                case Keys.Right:
                    pieceMobile.ADroite();
                    break;

                case Keys.Left:
                    pieceMobile.AGauche();
                    break;

                case Keys.Up:
                    pieceMobile.Rotation();
                    break;

                case Keys.Down:
                    pieceMobile.Descendre();
                    break;

                case Keys.Space:
                    tas.Empiler(pieceMobile);

                    pieceMobile = fabrique.CreerPiece();
                    pieceMobile.SetLiCo(0, 3);

                    if (tas.Intersecte(pieceMobile))
                        pieceMobile = null;

                    Invalidate();
                    return true;

                default:
                    return base.ProcessDialogKey(keyData);
            }

            if (tas.Intersecte(pieceMobile))
                pieceMobile.Annuler();

            Invalidate();
            return true;
        }

    }
}