using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scrable
{
    public class Partie
    {
        private List<Joueur> joueurs = new List<Joueur>();
        private SacDeLettres sac = new SacDeLettres();
        private Plateau plateau = new Plateau();

        public void AjouterJoueur(string nom)
        {
            joueurs.Add(new Joueur(nom));
        }

        public void Demarrer()
        {
            Console.WriteLine("Début de la partie !");
            foreach (var joueur in joueurs)
            {
                joueur.PiocherLettres(sac, 7);
                joueur.AfficherLettres();
            }
            Jouer();
        }

        private void Jouer()
        {
            while (true)
            {
                foreach (var joueur in joueurs)
                {
                    plateau.Afficher();
                    joueur.AfficherLettres();

                    Console.WriteLine($"{joueur.Nom}, entrez la position de départ (ex: ligne,colonne) :");
                    string[] position = Console.ReadLine().Split(',');
                    int ligne = int.Parse(position[0]);
                    int colonne = int.Parse(position[1]);

                    Console.WriteLine("Entrez le mot :");
                    string mot = Console.ReadLine().ToUpper();

                    Console.WriteLine("Direction (H pour Horizontal, V pour Vertical) :");
                    char direction = Console.ReadLine().ToUpper()[0];

                    if (!joueur.PossedeLettres(mot))
                    {
                        Console.WriteLine("Vous n'avez pas toutes les lettres nécessaires !");
                        continue;
                    }

                    if (!plateau.PeutPlacerMot(ligne, colonne, mot, direction))
                    {
                        Console.WriteLine("Placement impossible !");
                        continue;
                    }

                    joueur.RetirerLettres(mot);
                    plateau.PlacerMot(ligne, colonne, mot, direction);
                    Console.WriteLine($"{joueur.Nom} a placé le mot : {mot} !");
                }
            }
        }
    }
}