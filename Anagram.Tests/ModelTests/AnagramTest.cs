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
    //get input marker


    //get an instance of input test word


    //compare marker char to test word char



    [TestMethod]
    //compare whole words for a true anagram
    public void WordCompare_CompareBearBare_True()
    {
    AnagramMatch testing5 = new AnagramMatch("bear");
    Assert.AreEqual(true, testing.CompareWord("bare"));
    }

    [TestMethod]
    //compare whole words for a partial anagram
    public void WordCompare_CompareLossGloss_True()
    {
      AnagramMatch testing6 = new AnagramMatch("loss");
      Assert.AreEqual(true, testing2.CompareWord("gloss"));
    }

    [TestMethod]
    //compare whole words for not an anagram
    public void WordCompare_CompareMoreLore_False()
    {
      AnagramMatch testing7 = new AnagramMatch("more");
      Assert.AreEqual(false, testing3.CompareWord("lore"));
    }
  }
}
