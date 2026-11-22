using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TD2Exo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PaireDes p1 = new PaireDes(6, 10);  // a 6-sided die and a 10-sided die
            Console.WriteLine(p1.ToString());  // {[5][8]}
            p1.Relancer(0);  // relance le premier dé
            Console.WriteLine(p1.ToString());  // {[2][8]}
            p1.Relancer(1);  // relance le second dé
            Console.WriteLine(p1.ToString());  // {[2][3]}
            Console.WriteLine(p1[0]);   // valeur du premier dé
            Console.WriteLine(p1[1]);   // valeur du second dé
        }
    }
}
