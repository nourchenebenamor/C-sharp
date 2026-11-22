using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamExo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Line l1 = new Line(4, 15);   //4 éléments vMax=15
                                         // valeurs initiales de l1 = 0  
            l1[2] = 4;
            l1[3] = 12;
            try
            {
                l1[0] = 27; //Exception Val>15
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
            Matrix m1 = new Matrix(2, 3, 12); //2 lignes 3 colonnes vMax=12
            m1[0, 1] = 3;  // indexeur à 2 indices
            m1[1, 2] = 7;
            Console.WriteLine(m1.ToString());
            // m1[0, 0] = 24; // produirait une exception Val>12
        }
    }
}
