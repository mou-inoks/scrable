using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scrable
{
    public class Plateau
    {
        private char[,] grille = new char[10, 10];

        public Plateau()
        {
            for (int i = 0; i < 10; i++)
                for (int j = 0; j < 10; j++)
                    grille[i, j] = '.';
        }

        public void Afficher()
        {
            Console.WriteLine("\nPlateau actuel :");
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                    Console.Write($"{grille[i, j]} ");
                Console.WriteLine();
            }
        }

        public bool PeutPlacerMot(int ligne, int colonne, string mot, char direction)
        {
            if (direction == 'H' && colonne + mot.Length > 10) return false;
            if (direction == 'V' && ligne + mot.Length > 10) return false;

            for (int i = 0; i < mot.Length; i++)
            {
                int x = ligne + (direction == 'V' ? i : 0);
                int y = colonne + (direction == 'H' ? i : 0);
                if (grille[x, y] != '.')
                    return false;
            }

            return true;
        }

        public void PlacerMot(int ligne, int colonne, string mot, char direction)
        {
            for (int i = 0; i < mot.Length; i++)
            {
                int x = ligne + (direction == 'V' ? i : 0);
                int y = colonne + (direction == 'H' ? i : 0);
                grille[x, y] = mot[i];
            }
        }
    }
}