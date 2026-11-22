using NSTTris;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP3
{
    internal class FabriqueBridee  : FabriquePieces 
    {
        public FabriqueBridee()
        {
            FabriqueSimple fabrique = new FabriqueSimple();

            for (int k = 0; k < fabrique.GetNbPieces(); k++)
            {
                PieceT p = fabrique.GetPiece(k);

                int[,] tab = new int[p.Hauteur, p.Largeur];

                for (int i = 0; i < p.Hauteur; i++)
                {
                    for (int j = 0; j < p.Largeur; j++)
                    {
                        tab[i, j] = p.At(p.Li+ i, p.Co + j);
                    }
                }

                AddPiece(new PieceBridee(tab, p.Li, p.Co));
            }
        }
        public override IPieceT CreerPiece()
        {
            Random rand = new Random();

            int k = rand.Next(GetNbPieces());
            PieceT p = GetPiece(k);

            int[,] tab = new int[p.Hauteur, p.Largeur];

            for (int i = 0; i < p.Hauteur; i++)
            {
                for (int j = 0; j < p.Largeur; j++)
                {
                    tab[i, j] = p.At(p.Li + i, p.Co + j);
                }
            }

            return new PieceBridee(tab, p.Li, p.Co);
        }
    }
}
