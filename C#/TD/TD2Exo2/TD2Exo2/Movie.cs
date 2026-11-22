using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TD2;

namespace TD2Exo2
{
    internal class Movie
    {
        private string _title;
        private ushort _year;
        private List<Review> _reviews;

        public Movie(string title, ushort year)
        {
            _title = title;
            _year = year;
        }
        public Movie(string title, ushort year, Review r)
        {
            _title = title;
            _year = year;
            _reviews = new List<Review>();
            _reviews.Add(r);
        }
        public void Add(Review r)
        {
            _reviews.Add(r);
        }
        public override string ToString()
        {
            if (_reviews != null)
            {
                float moy = 0;
                    foreach (Review r in _reviews)
                {
                    moy += r.Rating;
                }
                return _title + "[" + _year + "] rating:" + moy/_reviews.Count + "/5";
            }
            else { return _title + "[" + _year + "]"; }
        }
        
    }
}
