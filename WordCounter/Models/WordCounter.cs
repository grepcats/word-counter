using Microsoft.AspNetCore.Mvc;
using WordCounter.Models;

namespace WordCounter.Models
{
  public class RepeatCounter
  {
    private string _word;
    // private string _sentence;
    // private int _count;

    public RepeatCounter(string word)
    {
      _word = word;
      // _sentence = sentence;
      // _count = 0;
    }

    //methodsssss
    public string GetWord()
    {
      return "hello";
    }

  }
}
