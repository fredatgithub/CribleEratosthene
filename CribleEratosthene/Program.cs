using System;

namespace CribleEratosthene
{
  class Program
  {
    static void Main()
    {
      Action<string> display = Console.WriteLine;
      Action<string> display2 = Console.Write;
      display("Recherche des nombres premiers en utilisant le crible d'ératosthène");
      bool[] crible = new bool[200_000_000];
      crible = LibraryEratosthene.CribleEratosthene.InitializeCrible(crible);

      crible = LibraryEratosthene.CribleEratosthene.ApplyEratosthene(crible);
      for (int i = 0; i < crible.Length; i++)
      {
        if (crible[i])
        {
          display2($"{i} ");
        }

      }
      display("");
      display("Press any key to exit:");
      Console.ReadKey();
    }



    private bool IsPrime(int number)
    {
      bool result = false;

      return false;
    }

    private static bool[] Eratosthene(int limite, bool[] tableau)
    {
      /*
       Fonction Eratosthène(Limite)
    L = tableau de booléen de taille Limite, initialisé à Vrai
    Mettre à Faux les cases d'indice pair > 2
    L[1] = Faux
    i=3
    Tant que i*i≤Limite
        Si L[i]
            Pour j de i*i à Limite par pas de 2*i
                L[j] = Faux
            Fin pour
        Fin si
        i=i+1
    Fin tant que
    Retourner L
Fin fonction 
       * */
      bool result = false;
      tableau[1] = false;
      int i = 3;
      while (i * i <= limite)
      {
        if (tableau[i])
        {
          for (int j = i * i; j < limite; j = 2 * i)
          {
            tableau[j] = false;
          }
        }
        i++;
      }

      return tableau;
    }

    private object EratostheneRecursive(int limite)
    {
      /*
       FONCTION Eratosthène( entiers )
        SI premier entier au carré > dernier entier
          ALORS AFFICHE entiers
        SINON 
          AFFICHE premier entier
        EXECUTE Eratosthène( tous les entiers non multiples du premier entier )
        FIN SI
      FIN FONCTION 
       * */
      bool result = false;

      return result;

    }

  }
}
