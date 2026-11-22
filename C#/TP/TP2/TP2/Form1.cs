using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP2
{
    public partial class Form1 : Form
    {
        private int cellSize = 60;
        private GameBoard gameBoard;


        public Form1()
        {
            InitializeComponent();
            panel.Size = new Size(6 * cellSize, 6 * cellSize);
            gameBoard = new GameBoard(6, 6);
            gameBoard.Add(new RedPiece(2, 0));
            gameBoard.Add(new H2(3, 1, 1));
            gameBoard.Add(new H3(3, 3, 2));
            gameBoard.Add(new V3(3, 0, 3));
            gameBoard.Add(new V3(0, 5, 4));
            CreateButtons();
            label.Text = gameBoard.ToString();
        }
        private void CreateButtons()
        {
            Color[] colors = { Color.Red, Color.Blue, Color.Orange, Color.Green, Color.Purple };
            for (int i = 0; i < gameBoard.GetCount(); i++)
            {
                Piece piece = gameBoard[i]; // piece numéro i
                Button b = new Button();
                b.BackColor = colors[piece.GetValue() % 5];
                b.Size = new Size(cellSize * piece.Width(), cellSize * piece.Height());
                b.Location = new Point(piece.Col * cellSize, piece.Row * cellSize);
                b.Tag = i; // on attache le numéro de pièce au bouton
                b.MouseDown += this.OnClick; // MouseDown (right or left)
                panel.Controls.Add(b); // on ajoute le bouton au panel
            }
        }

       

        private void OnClick(object sender, MouseEventArgs e)
        {
            Button b = sender as Button;
            int iP = (int)b.Tag;
            
            bool moved = false;
            if (e.Button == MouseButtons.Right)
            {
                moved = gameBoard.MoveForWardPiece(iP);
            }
            else if (e.Button == MouseButtons.Left)
            {
                moved = gameBoard.MoveBackwardPiece(iP);
            }

            if (moved)
            {
                Piece p = gameBoard[iP];
                b.Location = new Point(p.Col * cellSize, p.Row * cellSize);
                label.Text = p.ToString();

            }
        }
    }
}
