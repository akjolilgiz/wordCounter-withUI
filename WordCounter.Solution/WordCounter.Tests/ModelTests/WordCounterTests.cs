using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCounter;

namespace WordCounter.Tests
{
  [TestClass]
  public class RepeatCounterTests
  {
    [TestMethod]
    public void GetWord_ReturnsWord_String()
    {
      //Arrange
      RepeatCounter newRepeatCounter = new RepeatCounter("orange", "apple");

      //Act
      string result = newRepeatCounter.GetWord();

      //Assert
      Assert.AreEqual("orange", result);
    }
    [TestMethod]
    public void SetWord_SetsWord_String()
    {
      //arrange
      RepeatCounter newRepeatCounter = new RepeatCounter("orange", "apple");

      //act
      string updatedWord = "watermelon";
      newRepeatCounter.SetWord(updatedWord);
      string result = newRepeatCounter.GetWord();

      //Assert
      Assert.AreEqual(updatedWord, result);
    }
    // [TestMethod]
    // public void SplitSentence_SplitSentence_String()
    // {
    //   //arrange
    //   string sentence = "I ate an orange";
    //   RepeatCounter newRepeatCounter = new RepeatCounter(sentence);
    //
    //
    //   //act
    //   string[] result = newRepeatCounter.SplitSentence();
    //
    //
    //   //Assert
    //   CollectionAssert.AreEqual(result, "I", "ate", "an", "orange");
    //
    //
    // }

  }
}
