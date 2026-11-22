using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TD2exo4
{
    internal class Monomial
    {
        private double _coeff;
        private uint _exp;

        public Monomial( double c=0, uint e=0)
        {
            _coeff = c;
            _exp = e;
        }
        public override string ToString()
        {
            return _coeff + "X^" + _exp;
        }

        public double Coef
        {
            get { return _coeff; }
        }
        public uint Exp
        { get { return _exp; } }

        public Monomial MultipliedBy (Monomial m)
        {
            Monomial mm = new Monomial(m._coeff * _coeff, m._exp + _exp);
            return mm;
        }
    }
}
