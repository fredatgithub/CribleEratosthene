using System;
using System.IO;
using System.Text;

namespace CribleEratosthene
{
  class Program
  {
    static void Main()
    {
      Action<string> display = Console.WriteLine;
      Action<string> display2 = Console.Write;
      display("Recherche des nombres premiers en utilisant le crible d'ératosthène");
      const int target = 200_000_000;
      bool[] crible = new bool[target];
      crible = LibraryEratosthene.CribleEratosthene.InitializeCrible(crible);

      crible = LibraryEratosthene.CribleEratosthene.ApplyEratosthene(crible);
      for (int i = 0; i < crible.Length; i++)
      {
        if (crible[i])
        {
          display2($"{i} ");
        }
      }

      string filename = $"primes_{target}.txt";
      WriteToFile(crible, filename, false);
      display(string.Empty);
      display($"Calcul terminé, le resultat a ete sauvegarde dans le fichier {filename}");
      display(string.Empty);
      display("Press any key to exit:");
      Console.ReadKey();
    }

    private static void WriteToFile(bool[] crible, string filename, bool appendFile = false)
    {
      // write the crible to a file one number per line
      try
      {
        using (StreamWriter sw = new StreamWriter(filename, append: appendFile, encoding: Encoding.UTF8))
        {
          for (int i = 0; i < crible.Length; i++)
          {
            if (crible[i])
            {
              sw.WriteLine(i);
            }
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
