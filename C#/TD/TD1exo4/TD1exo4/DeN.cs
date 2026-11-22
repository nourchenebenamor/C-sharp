using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TD1exo4
{
    internal class DeN
    {
        private static Random rand = new Random();  // une seule instance 
        private int _nface, _valeur;

        public DeN(int N=6)
        {
            _nface = N;
            if (_nface < 4) _nface = 4;
            Relancer();

        }
        public int GetNFaces() {  return _nface; }
        public void GetNFaces(out int nfaces) { nfaces = _nface; }
        public void Relancer()
        {
            _valeur = rand.Next(_nface) + 1;
        }

        public int Valeur
        { get { return _valeur; }
        }
        
        public override string ToString ()
        {
            return "[" + _valeur + "]";
        }
    }
}
