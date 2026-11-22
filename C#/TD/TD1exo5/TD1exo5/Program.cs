using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TD1exo5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Recipient verre = new Recipient(15, 5);  // capacite 15cl et contenu 5cl
            Recipient bouteille = new Recipient(75); // capacite 75cl contenu 0cl
            Recipient rDefaut = new Recipient();     // capacite 10cl contenu 0cl
            Console.WriteLine("verre = {0}", verre.ToString());
            Console.WriteLine("bouteille = {0}", bouteille.ToString());
            verre.Ajouter(8);
            verre.Retirer(3);
            Console.WriteLine("Capacite du verre ={0}", verre.Capacite);
            Console.WriteLine("Contenu du verre ={0}", verre.Contenu);
        }
    }
}
