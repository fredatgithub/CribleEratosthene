using System;
using System.Numerics;

namespace LibraryEratosthene
{
  public static class CribleEratosthene
  {
    public static bool[] InitializeCrible(bool[] crible)
    {
      for (int i = 0; i < crible.Length; i++)
      {
        crible[i] = true;
      }

      crible[0] = false; // 0 is not a prime
      crible[1] = false; // 1 is not a prime
      return crible;
    }

    public static bool[] ApplyEratosthene(bool[] tableau)
    {
      for (int i = 2; i < tableau.Length; i++)
      {
        for (int j = 2; j < tableau.Length; j++)
        {
          if (i * j > tableau.Length - 1)
          {
            break;
          }

          tableau[i * j] = false;
        }
      }

      return tableau;
    }

    public static bool[] Eratosthene(int limite, bool[] tableau)
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

    public static bool EratostheneRecursive(int limite)
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

    public static bool IsPrime(ulong number)
    {
      if (number <= 1)
      {
        return false;
      }

      if (number == 2 || number == 3 || number == 5)
      {
        return true;
      }

      if (number % 2 == 0 || number % 3 == 0 || number % 5 == 0)
      {
        return false;
      }

      for (ulong divisor = 7; divisor < Math.Sqrt(number); divisor += 2)
      {
        if (number % divisor == 0)
        {
          return false;
        }
      }

      return true;
    }

    public static bool IsPrime(BigInteger number)
    {
      if (number.IsEven)
      {
        return false;
      }

      if (number.Sign == 0 || number.Sign == -1)
      {
        return false;
      }

      if (number == 2 || number == 3 || number == 5)
      {
        return true;
      }

      if (number % 2 == 0 || number % 3 == 0 || number % 5 == 0)
      {
        return false;
      }

      var squareRoot = Math.Exp(BigInteger.Log(number) / 2);
      for (ulong divisor = 7; divisor < squareRoot; divisor += 2)
      {
        if (number % divisor == 0)
        {
          return false;
        }
      }

      return true;
    }
  }
}
