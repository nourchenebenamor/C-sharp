using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DataStructure
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                LList l1 = new LList();  // liste vide (état de l'objet l1 ?)
                l1.AddFront(4.2);
                l1.AddFront(5.7);
                l1.AddBack(6);
                Console.WriteLine(l1.ToString()); //"5.7->4.2->6->"
                Console.WriteLine(l1.Get(1));   // valeur dans le noeud #1 (2ième noeud)
                l1.Set(2, 13.6);
                Console.WriteLine(l1.ToString()); // "5.7->4.2->13.6->"
                l1.Set(4, 8);  // exception : le noeud #4 n'existe pas
                Console.WriteLine(l1.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
