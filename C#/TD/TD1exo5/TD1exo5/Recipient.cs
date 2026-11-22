using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TD1exo5
{
    internal class Recipient
    {
        private int _capacite, _contenu;
        public Recipient (int capacite=10 , int contenu = 0)
        {
            _capacite = capacite;
            _contenu = contenu;
        }
        public override string ToString()
        {
            return _contenu + "cl [/" + _capacite + "]";
        }
        public void Ajouter (int valeur)
        { _contenu = _contenu  + valeur;}

        public void Retirer (int valeur)
        { _contenu = _contenu - valeur; }

        public int Capacite
        { get { return _capacite; } }

        public int Contenu
            { get { return _contenu; } }
    }
}
