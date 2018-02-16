using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using WordCounter.Models;

namespace WordCounter.Tests
{
  [TestClass]
  public class RepeatCounterTest
  {
    //test methodssss
    [TestMethod]
    public void GetValues_FetchWordSentenceAndCount_String()
    {
      //arrange
      string controlWord = "cat";
      string controlSentence = "There is a cat over there. It is a big cat that I will pet.";
      int controlCount = 2;
      RepeatCounter newCounter = new RepeatCounter("cat", "There is a cat over there. It is a big cat that I will pet.");
      newCounter.SetCount();

      //act
      string wordResult = newCounter.GetWord();
      string sentenceResult = newCounter.GetSentence();
      int countResult = newCounter.GetCount();

      //assert
      Assert.AreEqual(wordResult, controlWord);
      Assert.AreEqual(sentenceResult, controlSentence);
      Assert.AreEqual(countResult, controlCount);
    }


    [TestMethod]
    public void SetValues_SetWordSentenceAndCount_Void()
    {
      //arrange
      string newWord = "small";
      string newSentence = "There is a small cat over there.";
      int newCount = 1;
      RepeatCounter newCounter = new RepeatCounter("cat", "There is a cat over there. It is a big cat that I will pet.");

      //act
      newCounter.SetWord(newWord);
      newCounter.SetSentence(newSentence);
      newCounter.SetCount();

      //assert
      Assert.AreEqual(newWord, newCounter.GetWord());
      Assert.AreEqual(newSentence, newCounter.GetSentence());
      Assert.AreEqual(newCount, newCounter.GetCount());
    }

    [TestMethod]
    public void SetCount_HandleCase_Void()
    {
        //arrange
        int controlCount = 2;
        RepeatCounter newCounter = new RepeatCounter("cat", "There is a Cat over there. It is a big cat that I will pet.");

        //act
        newCounter.SetCount();

        //assert
        Assert.AreEqual(controlCount, newCounter.GetCount());
    }

    [TestMethod]
    public void SetCount_HandlePunctuation_Void()
    {
        //arrange
        int controlCount = 2;
        RepeatCounter newCounter = new RepeatCounter("cat", "There is a Cat over there. It is a big cat.");

        //act
        newCounter.SetCount();

        //assert
        Assert.AreEqual(controlCount, newCounter.GetCount());
    }

    [TestMethod]
    public void IsValid_CheckForValidity_True()
    {
        //arrange
        bool controlEmpty = true;
        RepeatCounter newCounter = new RepeatCounter("cat", "There is a cat over there.");

        //act
        bool result = newCounter.IsValid();

        //assert
        Assert.AreEqual(controlEmpty, result);
    }

    [TestMethod]
    public void IsValid_CheckForValidity_False()
    {
        //arrange
        bool controlEmpty = false;
        RepeatCounter newCounter = new RepeatCounter("", "There is a cat over there.");

        //act
        bool result = newCounter.IsValid();

        //assert
        Assert.AreEqual(controlEmpty, result);
    }

    [TestMethod]
    public void GetMessage_FetchTheMessage_String()
    {
        //arrange
        string controlMessage = "Please enter a single word. Multiple-word inputs are not valid.";
        RepeatCounter newCounter = new RepeatCounter("cat cat", "There is a cat over there.");
        newCounter.IsValid();

        //act
        string result = newCounter.GetMessage();

        //assert
        Assert.AreEqual(result, controlMessage);
    }

    [TestMethod]
    public void GetAll_FetchAllCounters_List()
    {
        //arrange
        RepeatCounter catCounter = new RepeatCounter("cat", "the cat and the dog are great");
        RepeatCounter dogCounter = new RepeatCounter("dog", "the cat and the dog are great");
        RepeatCounter theCounter = new RepeatCounter("the", "the cat and the dog are great");
        List<RepeatCounter> controlList = new List<RepeatCounter>{catCounter, dogCounter, theCounter};

        //act
        List<RepeatCounter> result = RepeatCounter.GetAll();

        //assert
        Assert.AreEqual(result, controlList);
    }
  }
}
