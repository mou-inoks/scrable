using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scrable
{
    public class Joueur
    {
        public string Nom { get; set; }
        public List<Lettre> LettresEnMain { get; private set; } = new List<Lettre>();

        public Joueur(string nom)
        {
            Nom = nom;
        }

        public void PiocherLettres(SacDeLettres sac, int nombre)
        {
            for (int i = 0; i < nombre; i++)
            {
                Lettre? lettre = sac.PiocherLettre();
                if (lettre != null)
                    LettresEnMain.Add(lettre);
            }
        }

        public bool PossedeLettres(string mot)
        {
            List<char> copieLettres = LettresEnMain.Select(l => l.Caractere).ToList();
            foreach (char c in mot)
            {
                if (!copieLettres.Remove(c))
                    return false;
            }
            return true;
        }

        public void RetirerLettres(string mot)
        {
            foreach (char c in mot)
            {
                var lettre = LettresEnMain.FirstOrDefault(l => l.Caractere == c);
                if (lettre != null)
                    LettresEnMain.Remove(lettre);
            }
        }

        public void AfficherLettres()
        {
            Console.Write($"{Nom} a en main : ");
            foreach (var lettre in LettresEnMain)
            {
                Console.Write($"{lettre.Caractere} ");
            }
            Console.WriteLine();
        }
    }
}