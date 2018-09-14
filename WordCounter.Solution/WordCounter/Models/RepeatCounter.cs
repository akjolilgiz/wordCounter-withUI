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
    private int _id;
    private static List<RepeatCounter> _instances = new List<RepeatCounter>{};

    public RepeatCounter (string word, string sentence)
    {
      _word = word;
      _sentence = sentence;
      // _count = count;
      _id = _instances.Count;
      _instances.Add(this);
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
    public void SetSentence(string newSentence)
    {
      _sentence = newSentence;
    }
    public string[] SplitSentence()
    {
      string newString = "";
      foreach(char symbol in _sentence)
      {
        if (!char.IsPunctuation(symbol))
        {
          newString +=symbol;
        }
      }
      string[] splitSentence = newString.Split(' ');
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
    public static List<RepeatCounter>GetAll()
    {
      return _instances;
    }
    public int GetId()
    {
      return _id;
    }
    public static RepeatCounter Find(int searchId)
    {
      return _instances[searchId-1];
    }

  }
}
