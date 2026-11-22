using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1
{
    public class Grille
    {
        private int _hauteur;
        private int _largeur;
        private int _nBombes;
        private Cellule[,] _cellules;

        public Grille(int H, int L, int nBombes)
        {
            _hauteur = H;
            _largeur = L;
            _nBombes = nBombes;
            _cellules = new Cellule[H, L];

            for (int i = 0; i < H; i++)
            {
                for (int j = 0; j < L; j++)
                {
                    _cellules[i, j] = new Cellule();
                }
            }

            Random rand = new Random();
            int n = 0;

            while (n < _nBombes)
            { 
                int li = rand.Next(H);
                int co = rand.Next(L);

                if (_cellules[li, co].IsBomb == false)
                {
                    _cellules[li, co].IsBomb = true;
                }
                n++;
            }

            calculValeurs();

        }

        private int calculValeurCell(int li, int co)
        {
            int nb = 0;

            for (int i = li - 1; i <= li + 1; i++)
            {
                for (int j = co - 1; j <= co + 1; j++)
                {
                    if (i >= 0 && i < _hauteur && j >= 0 && j < _largeur)
                    {
                        if (i != li || j != co)
                            if (_cellules[i, j].IsBomb) nb++;
                    }
                }
            }
            return nb;
        }

        private void calculValeurs()
        {
            for (int i = 0; i < _hauteur; i++)
            {
                for (int j = 0; j < _largeur; j++)
                {
                    if (_cellules[i, j].IsBomb == false)
                    {
                        _cellules[i, j].Valeur = calculValeurCell(i, j);
                    }
                }
            }
        }

        public Cellule this[int li, int co]
        { get { return _cellules[li, co]; } }

        public override string ToString()
        {
            string str = "";
            for( int i=0; i< _hauteur;i++)
            { 
                for(int j=0; j< _largeur;j++)
                {
                    if (_cellules[i, j].IsBomb) str += "B ";
                    else str += _cellules[i, j].Valeur + " ";
                }
                str += "\n";
            }
            return str;
        }

        public void Decouvre(int li, int co)
        {  
            if (_cellules[li,co].Etat ==0 )
            { _cellules[li, co].Etat = 1; }
        }

        public void Marque(int li, int co)
        {
            if (_cellules[li, co].Etat == 0)
            { _cellules[li, co].Etat = 2; }

            else if (_cellules[li, co].Etat == 2)
            { _cellules[li, co].Etat = 0; }
        }
        
        public bool estPerdu()
        {
            for (int i = 0; i < _hauteur; i++)
            {
                for (int j = 0; j < _largeur;)
                {
                    if ((_cellules[i, j].IsBomb) && _cellules[i, j].Etat == 1)
                    { return true; }
                }
            }
            return false;
        }

        public bool estResolu()
        {
            
            int nb_marque = 0;
            for (int i=0; i< _hauteur;i++)
            {
                for(int j =0; j< _largeur; j++)
                {

                    if (_cellules[i, j].Etat == 2) { nb_marque++; };
                    if (_cellules[i, j].IsBomb == false && _cellules[i, j].Etat == 0) { return false; };
                    if (_cellules[i, j].IsBomb && _cellules[i, j].Etat != 2) {return false;}
                }
            }
            return (_nBombes == nb_marque);
        }

        public int Hauteur
        { get { return _hauteur; } }
        public int Largeur
        { get { return _largeur; } }



         
    }
}
