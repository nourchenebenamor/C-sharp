using System;
using System.Collections.Generic;
using System.Text;

namespace Test
{
        class CValue
        {
            private int _val;
            private int _max;
            public CValue(int val, int max = 10)
            {
                _max = Math.Max(0, max); //_max>=0
                _val = Math.Min(val, _max); //_val<=_max
            }
            public int Val
            {
                get { return _val; }
                set
                {
                    if (value > _max)
                        throw new Exception("Val>" + _max);
                    _val = value;
                }
            }
            public override string ToString()
            {
                return _val.ToString();
            }
        }
}

