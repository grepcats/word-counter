using Microsoft.AspNetCore.Mvc;
using WordCounter.Models;

namespace WordCounter.Models
{
  public class RepeatCounter
  {
        private string _word;
        private string _sentence;
        private int _count;
        private string _message;

    public RepeatCounter(string word, string sentence)
    {
        _word = word;
        _sentence = sentence;
        _count = 0;
        _message = "";
    }

    public string GetWord() { return _word; }

    public void SetWord(string newWord) { _word = newWord; }

    public string GetSentence() { return _sentence; }

    public void SetSentence(string newSentence) { _sentence = newSentence; }

    public int GetCount() { return _count; }

    public string GetMessage() { return _message; }

    public bool IsValid()
    {
        if (_word == "" || _sentence == "")
        {
            _message = "The program can't search on blank entries! Please try again.";
            return false;
        }
        if (_word.Contains(" "))
        {
            _message = "Please enter a single word. Multiple-word inputs are not valid.";
            return false;
        }
        else { return true; }
    }

    public void SetCount()
    {
        string[] splitSentence = _sentence.Split(' ');
        string lowerWord = _word.ToLower();
        int counter = 0;

        foreach (string word in splitSentence)
        {
            string lowerSentenceWord = word.ToLower();

            if (lowerSentenceWord[word.Length-1] == '.' || lowerSentenceWord[word.Length-1] == ',' || lowerSentenceWord[word.Length-1] == '?' || lowerSentenceWord[word.Length-1] == '!')
            {
                lowerSentenceWord = lowerSentenceWord.Substring(0, word.Length-1);
            }

            if (lowerSentenceWord == lowerWord) { counter++; }
        }
        _count = counter;
    }
  }
}
