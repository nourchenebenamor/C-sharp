using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ExamExo1
{
    internal class Matrix
    {
        private Line[] _lines;
        public Matrix(int r, int c, int vMax)
        {
            _lines = new Line[r];
            for (int i = 0; i < r; i++)
            {
                _lines[i] = new Line(c, vMax);
            }
        }
        public int this[int r, int c]
        {
            get
            {
                if (r > 0 && r <= _lines.Length && c > 0 && c <= getColumns())
                    return _lines[r][c];
                else throw new IndexOutOfRangeException("invalid index");
            }
        }
        public int getRows()
        { return _lines.Length; }
        public int getColumns()
        {
            int i = 0;
            while (_lines[i] != null)
            { i++; }
            return i;
        }
        public override string ToString()
        {
            string str = "";
            for (int i = 0; i < _lines.Length; i++)
            {
                for (int j = 0; j < getColumns(); j++)
                {
                    str += _lines[i][j].ToString() + " ";
                }
                str += "\n";
            }
            return str;
        }


























        /*private Line[] _lines;

        public Matrix(int r, int c, int vMax)
        { 
            _lines = new Line[r];
            for (int i = 0; i <  r; i++) { _lines[i]= new Line(c, vMax); } }
        public int getRows() { return _lines.Length; }
        public int getColumns() { return _lines[0].GetSize(); }

        public int this[int r, int c]
        {
            get { return _lines[r][c]; }
            set { _lines[r][c] = value; }
        }
        public override string ToString()
        {
            string str = "";
            for(int i = 0; i <this.getRows() ;i++)
            {
                for (int j = 0; j < this.getColumns(); j++)
                { str += _lines[i][j].ToString() + " "; }
                str += "\n";
            }
            return str;
        }*/
    }
}
