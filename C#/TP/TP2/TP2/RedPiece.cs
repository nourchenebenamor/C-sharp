using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2
{
    internal class RedPiece : H2
    {
        public RedPiece(int r, int c) : base(r,c,0) { }
        public override string ToString()
        {
            return "[R(" + base.Row + "," + base.Col + ")]";
        }

    }
}
