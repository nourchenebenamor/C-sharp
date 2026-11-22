using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TD2exo4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Monomial m1 = new Monomial(2.5, 2); //2,5X^2
            Monomial m2 = new Monomial(3.5);  //3,5  (3,5X^0)
            Monomial m3 = new Monomial();  //0  (0X^0)
            Monomial m4 = m1.MultipliedBy(m1);
            Console.WriteLine("m1={0}", m1);
            Console.WriteLine("m2={0}", m2);
            Console.WriteLine("m3={0}", m3);
            Console.WriteLine("m4={0}", m4);
            // constraint : each Polynomial has at least 1 monomial 
            Polynomial p1 = new Polynomial(new Monomial(2, 1));
            Polynomial p2 = new Polynomial(new Monomial(3.5, 2));
            Console.WriteLine("p1={0}", p1);
            Console.WriteLine("p2={0}", p2);
            Polynomial p3 = null;
            p3 = p1.MultipliedBy(p2);
            Console.WriteLine("p3={0}", p3);
            p1.Add(new Monomial(1.5, 2));
            p1.Add(new Monomial(1.5, 1));
            p2.Add(new Monomial(3, 4));
            p3 = p1.MultipliedBy(p2);
            Console.WriteLine("p1={0}", p1);
            Console.WriteLine("p2={0}", p2);
            Console.WriteLine("p3={0}", p3);
        }
    }
}
