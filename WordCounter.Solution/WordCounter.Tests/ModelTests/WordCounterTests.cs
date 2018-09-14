// using Microsoft.VisualStudio.TestTools.UnitTesting;
// using Microsoft.AspNetCore.Mvc;
// using System.Collections.Generic;
// using WordCounter.Controllers;
// using WordCounter.Models;
//
// namespace WordCounter.Tests
// {
//   [TestClass]
//   public class RepeatCounterTests
//   {
//     [TestMethod]
//     public void GetWord_ReturnsWord_String()
//     {
//       //Arrange
//       RepeatCounter newRepeatCounter = new RepeatCounter("orange", "apple");
//
//       //Act
//       string result = newRepeatCounter.GetWord();
//
//       //Assert
//       Assert.AreEqual("orange", result);
//     }
//     [TestMethod]
//     public void SetWord_SetsWord_String()
//     {
//       //arrange
//       RepeatCounter newRepeatCounter = new RepeatCounter("orange", "apple");
//
//       //act
//       string updatedWord = "watermelon";
//       newRepeatCounter.SetWord(updatedWord);
//       string result = newRepeatCounter.GetWord();
//
//       //Assert
//       Assert.AreEqual(updatedWord, result);
//     }
//     [TestMethod]
//     public void SplitSentence_SplitSentence_String()
//     {
//       //arrange
//       RepeatCounter newRepeatCounter = new RepeatCounter("orange", "I ate an orange");
//       string[] newString = {"I", "ate", "an", "orange"};
//
//       //act
//       string[] result = newRepeatCounter.SplitSentence();
//
//
//       //Assert
//       CollectionAssert.AreEqual(result, newString);
//     }
//     [TestMethod]
//     public void Count_GetTheAmountOfCount_int()
//     {
//       //arrange
//       string word = "orange";
//       string sentence = "I ate orange and orange and more orange";
//       RepeatCounter newCount = new RepeatCounter(word, sentence);
//
//       //Assert
//
//       int number = newCount.Count();
//       // Assert
//
//       Assert.AreEqual(number, 3);
//     }
//
//
//   }
// }
