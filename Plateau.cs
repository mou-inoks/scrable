using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scrable
{
    public class Plateau
    {
        private Jeton[,] grille = new Jeton[15, 15];

        public bool PlacerJeton(Jeton jeton)
        {
            if (grille[jeton.X, jeton.Y] == null)
            {
                grille[jeton.X, jeton.Y] = jeton;
                return true;
            }
            return false;
        }

        public int CalculerPointsMot(List<Jeton> mot)
        {
            int total = 0;
            foreach (var jeton in mot)
            {
                total += jeton.Lettre.Valeur;
            }
            return total;
        }
    }
}