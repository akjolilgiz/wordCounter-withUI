using System.Collections;
using System;
using System.Collections.Generic;

namespace WordCounter.Models
{
  public class RepeatCounter
  {
    private string _word;
    private string _sentence;
    private int _count;

    public RepeatCounter (string word, string sentence)
    {
      _word = word;
      _sentence = sentence;
    }
    public string GetWord()
    {
      return _word;
    }
    public void SetWord(string newWord)
    {
      _word = newWord;
    }
    public string GetSentence()
    {
      return _sentence;
    }
    public string[] SplitSentence()
    {

      string[] splitSentence = _sentence.Split(' ');
      return splitSentence;
    }
    public int GetCount()
    {
      return _count;
    }
    public void SetCount(int newCount)
    {
      _count = newCount;
    }
    public int Count()
    {
      int count = 0;
      // string[] splitSentence = SplitSentence();
      foreach(string words in SplitSentence())
      {
        if (words.Equals(_word))
        {
          count ++;
        }
      }

       return count;
    }

  }
}
