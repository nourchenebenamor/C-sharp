using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teams
{
    public class Group : IGroup
    {
        private List<Member> _members; 
        public Group(Member m)
        {
            _members = new List<Member>();
            _members.Add(m);
        }
        public void Add(Member m)
        {
            _members.Add(m);
        }

        public int Size
        {
            get { return _members.Count; }
        }

        public Member Get(int idx)
        { return _members[idx]; 
        }

        public override string ToString()
        {
            string str = "";
            str = "group with" + _members.Count + "members:";
            foreach (Member m in _members)
            {
                str = str + m.ToString();
            }
            return str;
        }
    }
}
