using System;
using System.IO;

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

      const string filename = "primes_200_millions.txt";
      WriteToFile(crible, filename);
      display($"Calcul terminé, le resultat a ete saugarde dans le fichier {filename}");
      display(string.Empty);
      display("Press any key to exit:");
      Console.ReadKey();
    }

    private static void WriteToFile(bool[] crible, string filename, bool appendFile = false)
    {
      // write the crible to a file one number per line
      try
      {
        StreamWriter sw = new StreamWriter(filename, appendFile);
        for (int i = 0; i < crible.Length; i++)
        {
          if (crible[i])
          {
            sw.WriteLine(crible[i]);
          }
        }
      }
      catch (Exception exception)
      {
        Console.WriteLine(exception.ToString());
      }
    }
  }
}
