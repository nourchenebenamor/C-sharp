using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2
{
    internal class HPiece : Piece
    {
        public HPiece(int r, int c, int size, int val) : base(r, c, size, val){ }
        public override string ToString()
        {
            return "H" + Size + "(" + Row + "," + Col + ")";
        }

        override public void Forward()
        {
            Col++;
        }
        override public void Backward()
        {
            Col--;
        }
        public override bool Overlaps(int r, int c)
        {
            return (r == Row && c>= Col && c< Col+Width())  ;
        }

        public override int Width()
        {
             return Size; 
        }
        public override int Height()
        {
            return 1;
        }

    }
}
