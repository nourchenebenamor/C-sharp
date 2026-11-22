using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace supermarket
{

    class Item
    {
        private string _name;
        private double _price;  // euros
        private double _weight; // grammes
        public Item(string name, double pr, double w)
        {
            _name = name;
            _price = pr;
            _weight = w;
        }
        public string Name { get { return _name; } }
        public double Price { get { return _price; } }
        public double Weight { get { return _weight; } }
        public override string ToString()
        {
            return Name + "(" + _weight.ToString()
        + "g) " + _price + "E";
        }
    }
}
