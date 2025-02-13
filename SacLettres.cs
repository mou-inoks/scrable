
namespace Scrable;
public class SacDeLettres
{
    private List<Lettre> lettres = new List<Lettre>();
    private static Dictionary<char, (int valeur, int quantite)> sacLettresComplet = new Dictionary<char, (int, int)>
    {
        {'A', (1, 9)}, {'B', (3, 2)}, {'C', (3, 2)}, {'D', (2, 3)}, {'E', (1, 15)}, {'F', (4, 2)},
        {'G', (2, 2)}, {'H', (4, 2)}, {'I', (1, 8)}, {'J', (8, 1)}, {'K', (10, 1)}, {'L', (1, 5)},
        {'M', (3, 3)}, {'N', (1, 6)}, {'O', (1, 6)}, {'P', (3, 2)}, {'Q', (8, 1)}, {'R', (1, 6)},
        {'S', (1, 6)}, {'T', (1, 6)}, {'U', (1, 6)}, {'V', (4, 2)}, {'W', (10, 1)}, {'X', (10, 1)},
        {'Y', (10, 1)}, {'Z', (10, 1)}
    };

    public SacDeLettres()
    {
        InitialiserSac();
    }

    private void InitialiserSac()
    {
        foreach (var lettre in sacLettresComplet)
        {
            for (int i = 0; i < lettre.Value.quantite; i++)
            {
                lettres.Add(new Lettre(lettre.Key, lettre.Value.valeur));
            }
        }
    }

    public Lettre? PiocherLettre()
    {
        if (lettres.Count == 0) return null;
        Random rnd = new Random();
        int index = rnd.Next(lettres.Count);
        Lettre lettre = lettres[index];
        lettres.RemoveAt(index);
        return lettre;
    }

    public bool EstVide()
    {
        return lettres.Count == 0;
    }
}