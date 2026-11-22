using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TD2Exo1
{
    internal class PaireDes
    {
        List<DeN> _des;

        public PaireDes(int nd1, int nd2)
        {
            _des = new List<DeN>(2);
            _des.Add(new DeN(nd1));
            _des.Add(new DeN(nd2));
            
        }
        public override string ToString()
        {
            return "{" + _des[0] + _des[1] + "}";
        }
        public void Relancer(int n)
        {
            if (n == 0) { _des[0].Relancer(); }
            else
            {
                _des[1].Relancer();
            }
        }
        public int this[int idx]
        {
            get
            {
                if (idx == 0) return _des[0].Valeur;
                else return _des[1].Valeur;
            }
        }

    }
}
    /* TD2b
    internal class PaireDes
    {
        DeN[] _des;

        public PaireDes (int nd1, int nd2)
        {
            _des = new DeN[2];
            _des[0] = new DeN(nd1);
            _des[1] = new DeN( nd2);
        }
        public override string ToString()
        {
            return "{" + _des[0] + _des[1] + "}";
        }
        public void Relancer(int n)
        {
            if (n == 0) { _des[0].Relancer(); }
            else
            {
                _des[1].Relancer();
            }
        }
        public int this[int idx]
        {
            get
            {
                if (idx == 0) return _des[0].Valeur;
                else return _des[1].Valeur;
            }
        }

    }*/




/* TD2a
internal class PaireDes
{
    DeN _d1;
    DeN _d2;

    public PaireDes (int nd1, int nd2)
    {
        _d1 = new DeN(nd1);
        _d2 = new DeN(nd2);
    }
    public override string ToString () {
        return "{" + _d1 + _d2 + "}"; }
    public void Relancer(int n)
    {
        if (n == 0) { _d1.Relancer(); }
        else
        {
            _d2.Relancer();
        }
    }
    public int this[int idx]
    {
        get
        {
            if (idx == 0) return _d1.Valeur;
            else return _d2.Valeur;
        }
    }

}*/

