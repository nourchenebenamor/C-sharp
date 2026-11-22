using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teams
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Member m1 = new Member("Peter", 35, true);
            Member m2 = new Member("Julia", 28, false);
            Console.WriteLine(m1); // sortie->"Peter(M) age=35"
            Console.WriteLine(m2); // sorties->"Julia(F) age=28"

            Pair p1 = new Pair(m1, m2); // a group with 2 members
            Console.WriteLine(p1.Get(1)); // sortie-> "Julia(F) age=28"
            Console.WriteLine(p1); // sortie-> Pair:[Peter(M) age = 35; Julia(F) age = 28]

            Group g1 = new Group(m1); // Group (with at least 1 member)
            g1.Add(m2);
            g1.Add(new Member("Katy", 38, false));
            Console.WriteLine(g1);
            //sortie-> Group with 3 members:Peter(M) age=35;Julia(F) age=28;Katy(F) age=38; }
            Group g2 = new Group(new Member("John", 54, true));

            Team t1 = new Team(); // initially with no group
            t1.Add(p1);
            t1.Add(g1);
            t1.Add(g2);
            Console.WriteLine(t1[1]); // prints g1
            List<Pair> lP = t1.GetPairs(); // only the Pair objects
            List<Member> females = t1.GetFemales(); // all females from t1
            foreach (Member me in females)
            {
                Console.WriteLine(me);
            }
        }
    }
}
