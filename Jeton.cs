using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scrable
{
    public class Jeton
    {
        public Lettre Lettre { get; set; }
        public int X { get; set; }  
        public int Y { get; set; }

        public Jeton(Lettre lettre, int x, int y)
        {
            Lettre = lettre;
            X = x;
            Y = y;
        }
    }
}