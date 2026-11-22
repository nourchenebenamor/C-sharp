using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    class Node
    {
        private Node _next;
        private double _val;
               
        public Node(double V,Node next=null){
            _val = V;   _next = next;
        }

        public double Value{
            get { return _val; }
            set { _val = value; }
        }

        public Node Next{
            get { return _next; }
            set { _next = value; }
        }
    }
}
