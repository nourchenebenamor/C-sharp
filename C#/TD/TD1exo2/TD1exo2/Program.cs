using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TD1exo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            Droite d1 = new Droite(1.5, 2);
            Droite d2 = new Droite(-2.25, rand.NextDouble() * 5);
            Console.WriteLine(d1);
            Console.WriteLine(d2);
            // formattage p47 poly
            Console.WriteLine("d1.GetValue(2)={0:F2}", d1.GetValue(2));
            if (d1.Intersecte(d2))
            {
                double x = 0, y = 0;
                d1.GetIntersection(d2, out x, out y);
                Console.WriteLine("x={0:F2} y={1:F2}", x, y);
                Console.WriteLine("d1.GetValue(x)={0:F2}", d1.GetValue(x));
                Console.WriteLine("d2.GetValue(x)={0:F2}", d2.GetValue(x));
            }
        }
    }
}
