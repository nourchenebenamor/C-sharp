using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP1
{
    public class Cellule
    {

        private int _valeur;
        private Boolean _isBomb;
        private int _etat;

        public Cellule ()
        {
            _valeur = 0;
            _isBomb = false;
            _etat = 0;
        }

        public int Valeur
        {
            get { return _valeur; }
            set { _valeur = value; }
        }

        public Boolean IsBomb
        {
            get { return _isBomb; }
            set { _isBomb = value; }
        }

        public int Etat
        { get { return _etat; }
        set { _etat = value; } }

    }
}
