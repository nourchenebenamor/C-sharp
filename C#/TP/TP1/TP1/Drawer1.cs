using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1
{
    using System.Drawing;
    public class Drawer1 : IDessinateur
    {
        private int _larCell;
        public Drawer1(int larCell)
        {
            _larCell = larCell;
        }

        public void Dessine(Grille grille, Graphics graphics)
        {
            Font f = new Font("Consolas", 18);

            for (int i = 0; i < grille.Hauteur; i++)
            {
                for (int j = 0; j < grille.Largeur; j++)
                {
                    int x = j * _larCell;
                    int y = i * _larCell;

                    Cellule c = grille[i, j];


                    if (c.Etat == 0)
                    {
                        graphics.FillRectangle(Brushes.LightGray, x, y, _larCell, _larCell);
                    }
                    else if (c.Etat == 2)
                    {
                        graphics.FillRectangle(Brushes.LightGray, x, y, _larCell, _larCell);

                        graphics.DrawString("M", f, Brushes.Red, x + 8, y + 5);
                    }
                    else
                    {
                        graphics.FillRectangle(Brushes.White, x, y, _larCell, _larCell);
                        if (c.IsBomb)
                        {
                            graphics.DrawString("B", f, Brushes.Red, x + 8, y + 5);
                        }
                        else if (c.Valeur != 0)
                        {
                            graphics.DrawString(c.Valeur.ToString(), f, Brushes.Blue, x + 8, y + 5);
                        }
                    }
                    graphics.DrawRectangle(Pens.Black, x, y, _larCell, _larCell);
                }

            }
            f.Dispose();
        }

    }
}
