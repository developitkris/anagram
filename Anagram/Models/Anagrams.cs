using System;
using System.Collections.Generic;

namespace Anagrams
{
  public class AnagramMatch
  {
    private static _marker;
    private static _otherWords;
    private static List<string> _wordsToCheck = List<string>{};
    private static List<string> _anagrams = List<string>{};
    private static List<string> _not = List<string>{};

    public class AnagramMatch(string word1, List otherWords)
    {
      _marker = word1;
      _otherWords = otherWords;
    }
    public void SetMarker(string firstWord)
    {
      _marker = firstWord;
    }
    public string GetMarker()
    {
      return _marker;
    }
    public void SetAll(List otherWords)
    {
      _wordsToCheck = otherWords;
    }
    public string GetAll()
    {
      return _wordsToCheck;
    }
    public void SetAna(List anagrams)
    {
      _anagrams = anagrams;
    }
    public string GetAna()
    {
      return _anagrams;
    }
    public void SetNot(List not)
    {
      _not = not;
    }
    public string GetNot()
    {
      return _not;
    }
    public string CompareWords(string word1, string otherWords, string newWord)
    {
      for (string)

      for (var x=0; x<word1.Length; x++)
        if (otherword[x].Contains(word1[x])){
          _anagrams.Add(x);
        } else {
          _not.Add(x);
        }
        Console.WriteLine(newWord + ",");
    }

  }
}
