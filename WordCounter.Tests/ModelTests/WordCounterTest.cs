using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCounter.Models;

namespace WordCounter.Tests
{
  [TestClass]
  public class RepeatCounterTest
  {
    //test methodssss
    [TestMethod]
    public void GetValues_FetchWordAndSentence_String()
    {
      //arrange
      string controlWord = "cat";
      string controlSentence = "There is a cat over there. It is a big cat that I will pet.";
      RepeatCounter newCounter = new RepeatCounter("cat", "There is a cat over there. It is a big cat that I will pet.");

      //act
      string wordResult = newCounter.GetWord();
      string sentenceResult = newCounter.GetSentence();

      //assert
      Assert.AreEqual(wordResult, controlWord);
      Assert.AreEqual(sentenceResult, controlSentence);
    }

    [TestMethod]
    public void SetValues_SetWordAndSentence_Void()
    {
      //arrange
      string newWord = "small";
      string newSentence = "There is a small cat over there.";
      RepeatCounter newCounter = new RepeatCounter("cat", "There is a cat over there. It is a big cat that I will pet.");

      //act
      newCounter.SetWord(newWord);
      newCounter.SetSentence(newSentence);

      //assert
      Assert.AreEqual(newWord, newCounter.GetWord());
      Assert.AreEqual(newSentence, newCounter.GetSentence());
    }

    [TestMethod]
    public void GetCount_GetTheCount_Int()
    {
        //arrange
        int controlCount = 2;
        RepeatCounter newCounter = new RepeatCounter("cat", "There is a cat over there. It is a big cat that I will pet.");
        newCounter.SetCount();

        //act
        int result = newCounter.GetCount();

        //assert
        Assert.AreEqual(result, controlCount);
    }

    [TestMethod]
    public void SetCount_SetTheCount_Void()
    {
        //arrange
        int controlCount = 2;
        RepeatCounter newCounter = new RepeatCounter("cat", "There is a cat over there. It is a big cat that I will pet.");

        //act
        newCounter.SetCount();

        //assert
        Assert.AreEqual(controlCount, newCounter.GetCount());
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
    public void IsEmpty_CheckForEmptyValues_False()
    {
        //arrange
        bool controlEmpty = false;
        RepeatCounter newCounter = new RepeatCounter("cat", "There is a cat over there.");

        //act
        bool result = newCounter.IsEmpty();

        //assert
        Assert.AreEqual(controlEmpty, result);
    }
  }
}
