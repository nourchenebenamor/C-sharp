using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teams
{
    public class Member
    {
        private string _name;
        private int _age;
        private bool _male;

        public Member(string N,int A,bool Male)
        {
            _name = N; _age = A;_male = Male;
        }

        public string Name { get { return _name; } }
        public int Age { get { return _age; } }

        public bool IsMale() { return _male; }

        public override string ToString()
        {
            return string.Format("{0}({1}) age={2}", _name, IsMale()?'M':'F', _age);
        }
    }
}
