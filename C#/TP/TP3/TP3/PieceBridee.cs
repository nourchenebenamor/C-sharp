using NSTTris;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP3
{
    internal class PieceBridee : PieceT
    {
        private int _nbMouvements;
        private bool _dernierCoupCompte;
        public PieceBridee(int[,] tab, int li = 0, int co = 1)
            : base(tab, li, co) { }

        private PieceBridee(int[,] tab, int li, int co, int nbMouvements)
            : base(tab, li, co)
        {
            _nbMouvements = nbMouvements;
        }
        private void Compter() { _nbMouvements++; _dernierCoupCompte = true; }

        public override void ADroite() { base.ADroite(); Compter(); }
        public override void AGauche() { base.AGauche(); Compter(); }
        public override void Monter() { base.Monter(); Compter(); }
        public override void Descendre() { base.Descendre(); Compter(); }

        public override void Rotation()
        {
            if (_nbMouvements >= 5) return;
            base.Rotation();
            Compter();
        }

        public void SetLiCo(int li, int co)
        {
            base.SetLiCo(li, co);
            _dernierCoupCompte = false;
        }

        public  void Annuler()
        {
            base.Annuler();
            if (_dernierCoupCompte && _nbMouvements > 0)
                _nbMouvements--;
            _dernierCoupCompte = false;
        }

        
    }
}

