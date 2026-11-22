using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TD2exo4
{
    internal class Polynomial
    {
        List<Monomial> monomials;
        public Polynomial(Monomial m)
        {
            monomials = new List<Monomial>();
            monomials.Add(m);
        }
        public void Add(Monomial m)
        { monomials.Add(m); }
        public override string ToString()
        {
            string str = "";
            foreach (Monomial m in monomials)
            {
                str += m.ToString();
                if (m != monomials[monomials.Count - 1])
                {
                    str += " + ";
                }
            }
            return str;
        }
        public Polynomial MultipliedBy(Polynomial p)
        {
            Polynomial mp = new Polynomial(monomials[0].MultipliedBy(p.monomials[0]));
            for (int i=0;  i<monomials.Count; i++)
            {
                for(int j=1;  j<p.monomials.Count; j++)
                {
                    Monomial m = monomials[i].MultipliedBy(p.monomials[j]);
                    mp.Add(m);
                }
            }
            return mp;
            
        }
    }
}
