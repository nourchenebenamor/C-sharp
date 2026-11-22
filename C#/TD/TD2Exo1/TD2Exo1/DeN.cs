using System;
using System.Collections.Generic;
using System.Text;

namespace TD2Exo1
{
    class DeN
    {
        private int _valeur;
        private int _Nfaces;
        private static Random r = new Random();

        public DeN(int nbFaces=6){
            _Nfaces = nbFaces;
            if (_Nfaces < 4) _Nfaces = 4; // contraindre _Nfaces>=4
            Relancer();  
        }

        public int GetNFaces(){
            return _Nfaces;
        }

        public void GetNFaces(out int nFaces)
        {
            nFaces = _Nfaces;
        }

        public void Relancer()
        {
            _valeur = r.Next(_Nfaces) + 1;
        }
        public int Valeur
        {
            get { return _valeur; }
        }
        public override string ToString()
        {
            return "[" + Valeur.ToString() + "]";
        }
    }
}
