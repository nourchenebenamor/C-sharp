using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teams
{
    public interface IGroup
    {
        int Size{get;}
        Member Get(int idx);
    }
}
