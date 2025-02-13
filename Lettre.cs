using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scrable
{
    public class Lettre
    {
        public char Caractere { get; set; }
        public int Valeur { get; set; }

        public Lettre(char caractere, int valeur)
        {
            Caractere = caractere;
            Valeur = valeur;
        }
    }
}