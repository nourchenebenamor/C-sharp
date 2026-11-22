using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teams
{
    public class Team
    {
        private List<Group> _groups;
        public Team()
        {
            _groups = new List<Group>();
        }
        public void Add (Group g)
        { _groups.Add(g); }
        public int Size {  get { return _groups.Count; } }
        public IGroup this[int idx]
        {  get { return _groups[idx]; } }
        public List<Pair> GetPairs()
        {
            List<Pair> list = new List<Pair>();
            foreach (IGroup g in _groups)
            {
                if (g is Pair) { list.Add((Pair)g); }
            }
            return list;

        }
        public List<Member> GetFemales()
        {
            List<Member> list = new List<Member>();
            foreach (Group g in _groups)
            {
                for (int i = 0; i < g.Size; i++)
                {
                    if (g.Get(i).IsMale() == false)
                        list.Add(new Member(g.Get(i).Name, g.Get(i).Age, false));
                }
            }
            return list;
        }
    }
}
