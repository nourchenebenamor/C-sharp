using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TD1exo2
{
    internal class Droite
    {
        private double _pente, _y0;

        public Droite(double pente, double y0)
        {
            _pente = pente;
            _y0 = y0;
        }

        public override string ToString()
        {
            return "y =" + _pente +"x+" + _y0; 
        }

        public double GetPente() { return _pente; }
        public double GetY0() { return _y0; }
        public void Get(out double p, out double y0)
        {
            p = _pente;
            y0 = _y0;
        }

        public double GetValue (double x)
        { return _pente * x +  _y0; }
        public bool Intersecte (Droite d)
        {
            if (this._pente != d._pente)
            {
                return true;
            }
            else return false;
        }

        public void GetIntersection(Droite d, out double x, out double  y)
        {
            x = 0;
            y = 0;
            if (Intersecte(d))
            {
                x = (d._y0 - this._y0) / (this._pente - d._pente);
                y = this.GetValue(x);
            }

        }

   
    }
}
