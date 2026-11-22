using DataStructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    internal class LList
    {
        private uint _size;
        private Node _first;

        public LList()
        {
            _size = 0;
            _first = null;
        }

        public void AddFront( double Valeur)
        {
            _first = new Node(Valeur, _first);
            _size++;
        }
        public void AddBack(double Valeur)
        {
            if (_size == 0) { AddFront(Valeur); }
            else
            {
                Node n = _first;
                while (n.Next != null) { n = n.Next; }
                n.Next = new Node(Valeur, null);
                _size++;
            }
        }
        public double Get(uint pos)
        {
            if (pos < _size)
            {
                uint p = 0;
                Node n = _first;
                while (p < pos) { p++; n = n.Next; }
                return n.Value;
            }
            else
            {
                throw new Exception("Invalid number : node %" + pos.ToString());

            }
        }

        public void Set(int pos, double valeur)
        {
            if (pos < _size)
            {
                Node n = _first;
                int i = 0;
                while (i < pos)
                {
                    i++;
                    n = n.Next;
                }
                n.Value = valeur;
            }
            else
            {
                throw new Exception("Invalid number : node %" + pos.ToString());

            }

        }

        public override string ToString()
        {
            string str = "";
            uint i = _size;

            while (i>0)
            {
                str += Get(_size-1) + "->";
                i--;
            }
            return str;

        }
    }
}
