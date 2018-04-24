using Microsoft.VisualStudio.TestTools.UnitTesting;
using Anagrams.Models;
using System;
using System.Collectios.Generic;

namespace Anagrams.Tests
{
  [TestClass]
  public class AnagramTest : IDisposable
  {
    public void Dispose()
    {
      Word.DeleteAll();
    }

    [TestMethod]
    //true anagram
    public void WordCompare_CompareBearBare_True()
    {
    AnagramMatch testing = new AnagramMatch("bear");
    Assert.AreEqual(true, testing.CompareWord("bare"));
    }

    [TestMethod]
    //partial anagram
    public void WordCompare_CompareLossGloss_True()
    {
      AnagramMatch testing2 = new AnagramMatch("loss");
      Assert.AreEqual(true, testing2.CompareWord("gloss"));
    }

    [TestMethod]
    //not an anagram
    public void WordCompare_CompareMoreLore_False()
    {
      AnagramMatch testing3 = new AnagramMatch("more");
      Assert.AreEqual(false, testing3.CompareWord("lore"));
    }
  }
}
