using Microsoft.AspNetCore.Mvc;
using WordCounter.Models;

namespace WordCounter.Models
{
  public class RepeatCounter
  {
        private string _word;
        private string _sentence;
        private int _count;

    public RepeatCounter(string word, string sentence)
    {
        _word = word;
        _sentence = sentence;
        _count = 0;
    }

    public string GetWord()
    {
        return _word;
    }

    public void SetWord(string newWord)
    {
        _word = newWord;
    }

    public string GetSentence()
    {
        return _sentence;
    }

    public void SetSentence(string newSentence)
    {
        _sentence = newSentence;
    }

    public int GetCount()
    {
        return _count;
    }

    public void SetCount()
    {
        string[] splitSentence = _sentence.Split(' ');
        int counter = 0;

        foreach (string word in splitSentence)
        {
            if (word == _word)
            {
                counter++;
            }
        }
        _count = counter;
    }
  }
}
