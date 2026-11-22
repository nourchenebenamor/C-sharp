using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2
{
    internal class GameBoard
    {
        private int _width;
        private int _height;
        List<Piece> _pieces;

        public GameBoard(int H, int W)
        {
            _width = H;
            _height = W;
            _pieces = new List<Piece>();
        }
        public int GetWidth()
        { return _width; }
        public int GetHeight() { return _height; }
        public void Add(Piece p)
        { _pieces.Add(p); }
        public int GetCount()
        { return _pieces.Count; }
        public Piece this[int idx]
        {
            get
            {
                if (idx < GetCount())
                {
                    for (int i = 0; i < GetCount(); i++)
                    {
                        if (idx == i) return _pieces[i];
                    }
                }
                return null;
            }
        }
        public bool MoveForWardPiece(int idx)
        {
            for (int i = 0; i < GetCount(); i++)
            {
                if (idx != i)
                {
                    if (_pieces[idx].Overlaps(_pieces[i]))
                        { if (_pieces[idx].Col + _pieces[idx].Width() <= GetWidth() ) 
                        { return false; } }
                }
            }
            return true;
        }
        public bool MoveBackwardPiece(int idx)
        {
            for (int i = 0; i < GetCount(); i++)
            {
                if (idx != i)
                {
                    if (_pieces[idx].Overlaps(_pieces[i]))
                    {
                        if (_pieces[idx].Row + _pieces[idx].Height() <= GetHeight())
                        { return false; }
                    }
                }
            }
            return true;
        }

        public override string ToString()
        {
            string str = "";
            foreach (Piece p in _pieces)
            {
                str += p.ToString() + "\n";
            }
            return str;
        }
    }
}
