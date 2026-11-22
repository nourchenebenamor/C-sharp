using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TD2Exo2;

namespace TD2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Review r1 = new Review("Super cool!", 4);
            Console.WriteLine(r1);
            Movie m1 = new Movie("Jaws", 1975, r1); // film avec 1 avis
            m1.Add(new Review("Fantastic", 5));  // 1 avis supplémentaire
            Movie m2 = new Movie("Seven", 1995); // pas encore de note
            Console.WriteLine(m1);
            Console.WriteLine(m2);
        }
    }
}
