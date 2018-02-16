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
      RepeatCounter newCounter = new RepeatCounter("cat");

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
      RepeatCounter newCounter = new RepeatCounter("cat");

      //act
      newCounter.SetWord(controlWord);

      //assert
      Assert.AreEqual(controlWord, newCounter.GetWord());
    }
  }
}
