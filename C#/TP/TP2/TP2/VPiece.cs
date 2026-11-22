using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2
{
    internal class VPiece : Piece 
    {
        public VPiece(int r, int c, int size, int val) : base(r, c, size, val) { }
        public override string ToString()
        {
            return "V" + Size + "(" + Row + "," + Col + ")";
        }

        override public void Forward()
        {
            Row++;
        }
        override public void Backward()
        {
            Row--;
        }
        public override bool Overlaps(int r, int c)
        {
            return (c == Col && r >= Row && r < Row + Height());
        }

        public override int Width()
        {
            return 1;
        }
        public override int Height()
        {
            return Size;
        }
    }
}
