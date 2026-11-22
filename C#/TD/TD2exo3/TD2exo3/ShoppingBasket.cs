using supermarket;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TD2exo3
{
    internal class ShoppingBasket
    {
        List<Item> _items;

        public ShoppingBasket( int capacity)
        {
            _items = new List<Item>(capacity);
        }

        public override string ToString()
        {
            string str ="";
            foreach (Item item in _items)
            {
                str += item.ToString() + "\n";
            }
            return str;
        }

        public double GetWeight()
        {
            double BasketWeight = 0;
            foreach (Item item in _items)
            {
                BasketWeight += item.Weight;
            }
            return BasketWeight;
        }
        public int GetSize ()
        {
            return _items.Count;
        }

        public double Total
        {
           
            get
            {
                double total = 0;
                foreach (Item item in _items)
                {
                    total += item.Price;
                }
                return total;
            }
        }
        public int Capacity
        {
            get
            {
                int capacity = 0;
                foreach (Item item in _items)
                {
                    capacity += 1;
                }
                return capacity;
            }
        }
        public void Add(Item item)
        {
            _items.Add(item);
        }
        public void RemoveLast()
        { _items.RemoveAt(0);}

        public Item this[int idx]
        {
            get
            {
                if (GetSize() != 0)
                {
                    for (int i = 0; i < GetSize(); i++)
                    {
                        if (idx == i) return _items[i];
                    }
                }
                throw new ArgumentOutOfRangeException("Invalid index");
            }
        }
    }
}
