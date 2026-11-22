using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TD2
{
    class Review
    {
        private string _text;
        private ushort _rating;

        public Review(string text,ushort rating){
            _text = text;
            _rating = Math.Min(rating,(ushort)5);
        }

        public ushort Rating{   get { return _rating; }   }

        public string Text{     get { return _text; }     }

        public override string ToString(){
            return String.Format("{0} ({1}/5)",_text,_rating);
        }
    }
}

