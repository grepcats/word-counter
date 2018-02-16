using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCounter.Models;

namespace WordCounter.Tests
{
  [TestClass]
  public class RepeatCounterTest
  {
    //test methodssss
    [TestMethod]
    public void GetWord_FetchTheWord_String()
    {
      //arrange
      string controlWord = "cat";
      RepeatCounter newCounter = new RepeatCounter("cat", "There is a cat over there. It is a big cat that I will pet.");

      //act
      string result = newCounter.GetWord();

      //assert
      Assert.AreEqual(result, controlWord);
    }

    [TestMethod]
    public void SetWord_SetTheWord_Void()
    {
      //arrange
      string controlWord = "bat";
      RepeatCounter newCounter = new RepeatCounter("cat", "There is a cat over there. It is a big cat that I will pet.");

      //act
      newCounter.SetWord(controlWord);

      //assert
      Assert.AreEqual(controlWord, newCounter.GetWord());
    }

    [TestMethod]
    public void GetSentence_FetchTheSentence_String()
    {
      //arrange
      string controlSentence = "There is a cat over there. It is a big cat that I will pet.";
      RepeatCounter newCounter = new RepeatCounter("cat", "There is a cat over there. It is a big cat that I will pet.");

      //act
      string result = newCounter.GetSentence();

      //assert
      Assert.AreEqual(result, controlSentence);
    }

    [TestMethod]
    public void SetSentence_SetTheSentence_Void()
    {
        //arrange
        string newSentence = "There is a small cat over there.";
        RepeatCounter newCounter = new RepeatCounter("cat", "There is a cat over there. It is a big cat that I will pet.");

        //act
        newCounter.SetSentence(newSentence);

        //assert
        Assert.AreEqual(newSentence, newCounter.GetSentence());
    }

    [TestMethod]
    public void GetCount_GetTheCount_Int()
    {
        //arrange
        int controlCount = 2;
        RepeatCounter newCounter = new RepeatCounter("cat", "There is a cat over there. It is a big cat that I will pet.");

        //act
        int result = newCounter.GetCount();

        //assert
        Assert.AreEqual(result, controlCount);
    }
  }
}
