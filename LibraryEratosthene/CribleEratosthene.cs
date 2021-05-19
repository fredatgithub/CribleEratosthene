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
  }
}
