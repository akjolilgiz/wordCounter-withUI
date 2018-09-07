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

  }
}
