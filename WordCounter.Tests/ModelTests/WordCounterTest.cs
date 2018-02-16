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
  }
}
