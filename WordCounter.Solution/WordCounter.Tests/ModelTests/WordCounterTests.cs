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
      string word = "orange";
      RepeatCounter newRepeatCounter = new RepeatCounter(word);

      //Act
      string result = newRepeatCounter.GetWord();

      //Assert
      Assert.AreEqual(word, result);
    }
    [TestMethod]
    public void SetWord_SetsWord_String()
    {
      //arrange
      string word = "orange";
      RepeatCounter newRepeatCounter = new RepeatCounter(word);

      //act
      string updatedWord = "apple";
      newRepeatCounter.SetWord(updatedWord);
      string result = newRepeatCounter.GetWord();

      //Assert
      Assert.AreEqual(updatedWord, result);
    }

  }
}
