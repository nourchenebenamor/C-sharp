using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TD1exo4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DeN d1 = new DeN(10); //Dé à 10 faces
            DeN d2 = new DeN();
            Console.WriteLine("d1={0} N ={1}", d1.Valeur, d1.GetNFaces());
            Console.WriteLine("d2={0} N ={1}", d2.Valeur, d2.GetNFaces());
            d1.Relancer();
            Console.WriteLine("d1={0}", d1.Valeur);
            d2 = d1;
            d2.Relancer();
            int nFaces;
            d2.GetNFaces(out nFaces);
            Console.WriteLine("Nb faces de d2={0}", nFaces);
            Console.WriteLine("d1={0} N ={1}", d1.Valeur, d1.GetNFaces());
            Console.WriteLine("d2={0} N ={1}", d2.Valeur, d2.GetNFaces());
        }
    }
}
