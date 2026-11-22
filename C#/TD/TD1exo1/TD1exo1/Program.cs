using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TD1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cercle c1 = new Cercle(5, 11, 2.2);
            Cercle c2 = new Cercle(1, 3, 1.5);
            Console.WriteLine(c1.ToString());
            Console.WriteLine("aire de c1={0:F2}", c1.GetAire());
            Console.WriteLine("distance c1-c2={0:F2}", c1.GetDistance(c2));

            Random rand = new Random(); // objet générateur de nombres aléatoires
            Cercle[] tabC = new Cercle[150];
            for (int i = 0; i < 150; i++)
            {
                double r = rand.NextDouble() * 10; // double entre 0 et 10
                int x = rand.Next(100); // entier entre 0 et 99
                int y = rand.Next(100);
                tabC[i] = new Cercle(x, y, r);
            }
            Cercle cRand = tabC[rand.Next(150)];
            Console.WriteLine("Cercle choisi au hasard={0}", cRand);
            int sum = 0 ;
            for (int i = 0; i< 150; i++)
            {
                if ((cRand.Intersecte(tabC[i])))
                {
                    Console.WriteLine(tabC[i].ToString());
                    sum += 1;
                } 
            }
            Console.WriteLine("{0} cercle(s) intersecte(nt) {1}", sum, cRand);

        }
    }
}
