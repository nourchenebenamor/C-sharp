using NSTTris;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP3
{
    internal class Tas
    {
        private PieceT _bordG, _bordD, _bordH;
        int[,] bord;
        int[,] fond;
        private int _largeur, _hauteur;
        List<IPieceT> _pieces;
        public Tas(int Largeur, int Hauteur)
        {
            _pieces = new List<IPieceT>();
            _largeur = Largeur;
            _hauteur = Hauteur;
            bord = new int[Hauteur, 1];
            for (int i = 0; i < Hauteur; i++)
            {
                bord[i, 0] = 9;
            }
            fond = new int[1, Largeur];
            for (int i = 0; i < Largeur; i++)
            {
                fond[0, i] = 9;
            }

            _bordG = new PieceT(bord, 0, 0);
            _bordD = new PieceT(bord, 0, Largeur - 1);
            _bordH = new PieceT(fond, Hauteur - 1, 0) ;
        }

        public void Empiler(IPieceT p)
        {
            bool possible = true;
            while(possible)
            {
                p.Descendre();
                if (Intersecte(p))
                {
                    p.Annuler();
                    possible = false;
                    break;
                }
            }
            _pieces.Add(p);
        }
        public int GetHauteur()
        {
            return _hauteur;
        }
        public int GetLargeur()
        { return _largeur; }

        public IPieceT this[int n]
        { get { return _pieces[n]; } } 

        public int GetNbPieces()
        { return _pieces.Count; }
        public bool Intersecte(IPieceT p)
        {
            if (_bordG.Intersecte(p) || _bordD.Intersecte(p) || _bordH.Intersecte(p))
            {
                return true;
            }
            foreach (IPieceT piece in _pieces)
            { if (piece.Intersecte(p)) return true; }
            return false;
        }
        public int At(int li, int co)
        {
            if (_bordG.At(li, co) > 0)
                return _bordG.At(li, co);

            if (_bordD.At(li, co) > 0)
                return _bordD.At(li, co);

            if (_bordH.At(li, co) > 0)
                return _bordH.At(li, co);

            foreach (IPieceT piece in _pieces)
            {   
                int valeur = piece.At(li, co);
                if (valeur != 0) return valeur;
            }
            return 0;           
        }

        public IEnumerable<IPieceT> ElementsADessiner()
        {
            yield return _bordG;
            yield return _bordD;
            yield return _bordH;
            foreach (IPieceT p in _pieces) yield return p;
        }

    }
}
