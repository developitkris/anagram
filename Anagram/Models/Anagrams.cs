using System;
using System.Collections.Generic;

namespace Anagrams.Models
{
  public class AnagramMatch
  {
    private static _marker;
    private static _otherWords;
    private static int _id;
    private static List<string> _userInputs = new List<string>{};
    private static List<string> _anagrams = new List<string>{};
    private static List<string> _not = new List<string>{};

    public class AnagramMatch(string word1, List otherWords)
    {
      _marker = word1;
      _otherWords = otherWords;
      _userInputs.Add(this);
      _id = _otherWords.Count;
    }
    public void SetMarker(string firstWord)
    {
      _marker = firstWord;
    }
    public string GetMarker()
    {
      return _marker;
    }
    public void SetAll(List words)
    {
      foreach (string word in _userInputs)
        if (word[i] != word[0]){
          words = _otherWords;
        }
    }
    public string GetAll()
    {
      return _otherWords;
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
    public string CompareWords(string marker, List testWord)
    {
      char[] markerChar = marker.ToCharArray();
      char[] testChar = testWord.ToCharArray();

      foreach (testChar in _userInputs
        foreach (testChar[i] in _userInputs)
          if (testChar[i].Contains(marketChar[i])
            _anagrams.Add(i);
          } else {
            _not.Add(i);
          }
          return testChar.Join();
    }

    public static void ClearAll()
    {
      _userInputs.Clear();
    }
    public static AnagramMatch Find(string lookUpID)
    {
      return _userInputs[lookUpID-2];
    }

  }
}
