using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TD1exo3
{
    internal class Duree
    {
        private uint _min, _sec;
        public Duree(uint  min, uint sec=0)
        {
            Set(min, sec);
        }
        public override string ToString()
        {
            return _min + "'" + _sec + "''";
        }
        public void Set(uint min, uint sec)
        {
            _min = min + sec / 60;
            _sec = sec % 60;
        }
        public void Add(Duree d)
        {
            Set(_min + d._min, _sec + d._sec);
        }
        public void GetMS(out uint min, out uint sec)
        {
            min = _min;
            sec = _sec;
        }
        public uint ToSecondes ()
        {
            return _min * 60 + _sec;
        }
        public uint Minutes
        { get { return _min; }
          set { _min = value; } }

        public uint Secondes
        { get { return _sec; }
        set { _sec = value % 60;
            _min = _min + value / 60;}
        }
        public uint this[int idx]
        {
            get
            {
                if (idx == 0) return _min;
                else return _sec;
            }
        }
    

    }
}
