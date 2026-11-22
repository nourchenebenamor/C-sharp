using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TD1
{
    internal class Cercle
    {
        private int _x, _y;
        private double _rayon;

        public Cercle(int x, int y, double rayon)
        {
            _x = x;
            _y = y;
            _rayon = rayon;
        }

        public double GetAire()
        { return _rayon* _rayon * Math.PI; }

        public void GetCentre(out int x, out int y)
        {  x = _x; y = _y;}

        public void SetCenter(int x, int y)
        {  _x = x; _y = y;}

        public double GetDistance(Cercle c)
        {
            int x, y;
            double distance;
            x = c._x - this._x;
            y = c._y - this._y;
            return distance = Math.Sqrt(x*x + y*y);
        }

        public bool Intersecte(Cercle c)
        {
            if (Math.Abs(c._rayon - this._rayon) <= GetDistance(c) && (c._rayon + this._rayon) >= GetDistance(c))
            {
                return true;
            }
            else return false;
        }

        public override string ToString()
        {
            return "[(" + _x + "," + _y + ");r=" + _rayon + "]";
        }
    }
}
