using supermarket;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TD2exo3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ShoppingBasket p1 = new ShoppingBasket(3); // au plus 3 articles dans p1
            ShoppingBasket p2 = new ShoppingBasket(6); // au plus 6 articles dans p2
            Console.WriteLine(p1.ToString());
            Console.WriteLine("Capacity of p1={0}", p1.Capacity);
            p1.Add(new Item("Tuna", 1.3, 200));
            p1.Add(new Item("Cookies", 1.8, 400));
            p2.Add(new Item("Mustard", 1.4, 120));
            p2.Add(new Item("Bananas", 2.1, 600));
            p2.Add(new Item("Buns", 3.4, 500));
            Console.WriteLine(p1.ToString());
            Console.WriteLine(p2.ToString());
            Console.WriteLine("Weight of p1={0}", p1.GetWeight());
            Console.WriteLine("Total price of p1={0}", p1.Total);
            for (int i = 0; i < p2.GetSize(); i++)
            {
                Console.WriteLine("p2[{0}]={1}", i, p2[i]);
            }
            p2.RemoveLast();
            Console.WriteLine(p2.ToString());

        }
    }
}
