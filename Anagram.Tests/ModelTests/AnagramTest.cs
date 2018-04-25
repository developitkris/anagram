using Microsoft.VisualStudio.TestTools.UnitTesting;
using Anagrams.Models;
using System;
using System.Collections.Generic;

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
    public void GetMarker_MarkerIsInput_True()
    {
      AnagramMatch testing1 = new Anagram("a");
      Assert.AreEqual(true, testing.GetMarker("a"));
    }

    //get an instance of input test word
    public void GetTestWord_TestIsInput_True()
    {
      
    }

    //compare marker char to test word char -> a match

    //compare marker char to test word char -> not a match



    [TestMethod]
    //compare whole words -> anagram
    public void WordCompare_CompareBearBare_True()
    {
    AnagramMatch testing5 = new AnagramMatch("bear");
    Assert.AreEqual(true, testing.CompareWord("bare"));
    }

    [TestMethod]
    //compare whole words -> partial anagram
    public void WordCompare_CompareLossGloss_True()
    {
      AnagramMatch testing6 = new AnagramMatch("loss");
      Assert.AreEqual(true, testing2.CompareWord("gloss"));
    }

    [TestMethod]
    //compare whole words -> not an anagram
    public void WordCompare_CompareMoreLore_False()
    {
      AnagramMatch testing7 = new AnagramMatch("more");
      Assert.AreEqual(false, testing3.CompareWord("lore"));
    }
  }
}
