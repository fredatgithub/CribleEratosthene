using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestCrible
{
  [TestClass]
  public class UnitTestCrible
  {
    [TestMethod]
    public void TestMethod_Crible1()
    {
      var source = new bool[120];

      source = LibraryEratosthene.CribleEratosthene.InitializeCrible(source);
      source = LibraryEratosthene.CribleEratosthene.ApplyEratosthene(source);
      Assert.IsFalse(source[0]);
      Assert.IsFalse(source[1]);
      Assert.IsTrue(source[2]);
      Assert.IsTrue(source[3]);
      Assert.IsTrue(source[5]);
      Assert.IsFalse(source[6]);
      Assert.IsTrue(source[7]);
      Assert.IsFalse(source[8]);
      Assert.IsFalse(source[9]);
      Assert.IsFalse(source[10]);
      Assert.IsTrue(source[11]);
      Assert.IsFalse(source[12]);
      Assert.IsTrue(source[13]);
      Assert.IsFalse(source[14]);
      Assert.IsFalse(source[15]);
      Assert.IsFalse(source[16]);
      Assert.IsTrue(source[17]);
      Assert.IsFalse(source[18]);
      Assert.IsTrue(source[19]);
      Assert.IsFalse(source[20]);
      Assert.IsFalse(source[21]);
      Assert.IsFalse(source[22]);
      Assert.IsTrue(source[23]);
      Assert.IsFalse(source[24]);
      Assert.IsFalse(source[25]);
      Assert.IsFalse(source[26]);
      Assert.IsFalse(source[27]);
      Assert.IsFalse(source[28]);
      Assert.IsTrue(source[29]);

      Assert.IsTrue(source[31]);
      Assert.IsTrue(source[37]);

      Assert.IsTrue(source[41]);
      Assert.IsTrue(source[43]);
      Assert.IsTrue(source[47]);
    }
  }
}
