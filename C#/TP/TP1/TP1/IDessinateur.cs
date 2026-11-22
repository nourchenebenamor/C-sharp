using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1
{
    using System.Drawing;
    public interface IDessinateur
    {
        void Dessine(Grille grille, Graphics g);

    }
}
