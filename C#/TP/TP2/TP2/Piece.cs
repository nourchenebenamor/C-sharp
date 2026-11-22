using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2
{
    public abstract class Piece
    {
        private int _row;
        private int _col;
        private int _size;
        private int _value;

        public Piece(int r, int c, int size, int val)
        {
            _row = r; _col = c; _size = size; _value = val;
        }
        public abstract void Forward();
        public abstract void Backward();
        public int Size { get { return _size; }
            set { _size = value; }
        }
        public int GetValue () { return _value; }
        public int Row { get { return _row; }
            set { _row = value; }
        }
        public int Col { get { return _col; }
            set { _col = value; } }
        public abstract int Width();
        public abstract int Height();

        public abstract bool Overlaps(int r, int c);

        public bool Overlaps(Piece p)
        {
            for (int i = Row; i < Row + Height(); i++)
            {
                for (int j = Col; j < Col + Width(); j++)
                {
                    if (p.Overlaps(i,j))
                    {
                        return true;
                    }
                }

            }
            return false;
        }

    }
}
