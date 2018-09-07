namespace WordCounter
{
  public class RepeatCounter
  {
    private string _word;
    private string _sentence;

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
    public int Count()
    {
      int counts = 0;
      // string[] splitSentence = SplitSentence();
      foreach(string words in SplitSentence())
      {
        if (words.Equals(_word))
        {
          counts ++;
        }
      }

       return counts;
    }


  }
}
