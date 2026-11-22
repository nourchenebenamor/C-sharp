using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test;

namespace ExamExo1
{
    internal class Line
    {
        private CValue[] _vals;
        public Line(int size, int vMax)
        {
            _vals = new CValue[size];
            for (int i = 0; i < size; i++) {
                _vals[i] = new CValue(0, vMax); }
        }
        public int GetSize()
        {
            return _vals.Length;
        }
        public int this[int idx]
        { get
            {
                return _vals[idx].Val;
            }
            set
            {
                _vals[idx].Val = value;
            }
        }

    } }
        






















        /*private CValue[] _vals;

        public Line(int size, int vMax)
        {
            _vals = new CValue[size];

            for (int i = 0; i < size; i++)
            {
                _vals[i] = new CValue(0, vMax);
            }
        }
        public int GetSize()
        { return _vals.Length; }

        public int this[int idx]
        {
            get
            { return _vals[idx].Val; }
            set { _vals[idx].Val = value; }
        }

    }
}*/
