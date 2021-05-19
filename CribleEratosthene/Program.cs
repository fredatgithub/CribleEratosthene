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
  }
}
