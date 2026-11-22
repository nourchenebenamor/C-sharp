using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TD1exo3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Duree d1 = new Duree(24, 38);  // 24'38''
            Duree d2 = new Duree(2, 104);  // 3'44''
            Duree d3 = new Duree(5); //5 minutes 0 seconde
            Console.WriteLine(d1.ToString());
            Console.WriteLine(d2.ToString());
            d2.Add(d1);
            Console.WriteLine(d2.ToString());
            Console.WriteLine("d1={0} secondes", d1.ToSecondes());
            Console.WriteLine("Minutes de d1 = {0}", d1.Minutes);
            Console.WriteLine("Secondes de d1 = {0}", d1.Secondes);
            d3.Set(20, 110);
            Console.WriteLine("d3 = {0}", d3.ToString());
            uint M, S;
            d3.GetMS(out M, out S);
            Console.WriteLine("M={0} S={1}", M, S);
            // utiliser les [ ] sur un objet (cf indexeur)
            //Console.WriteLine("d3[0]={0} d3[1]={1}", d3[0], d3[1]);
        }
    }
}
