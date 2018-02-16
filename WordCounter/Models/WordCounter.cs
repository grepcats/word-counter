using Microsoft.AspNetCore.Mvc;
using WordCounter.Models;
using System.Collections.Generic;
using System;

namespace WordCounter.Models
{
    public class RepeatCounter
    {
        private string _word;
        private string _sentence;
        private int _count;
        private string _message;

        private static List<RepeatCounter> _counters = new List<RepeatCounter>{};

    public RepeatCounter(string word, string sentence)
    {
        _word = word;
        _sentence = sentence;
        _count = 0;
        _message = "";
        _counters.Add(this);
    }

    public string GetWord() { return _word; }

    public void SetWord(string newWord) { _word = newWord; }

    public string GetSentence() { return _sentence; }

    public void SetSentence(string newSentence) { _sentence = newSentence; }

    public int GetCount() { return _count; }

    public string GetMessage() { return _message; }

    public static List<RepeatCounter> GetAll() { return _counters; }

    public static void ClearAll() { _counters.Clear(); }

    public bool IsValid()
    {
        if (_sentence == "")
        {
            _message = "You left the text string blank. Please enter a string.";
            return false;
        }
        if (_word == "")
        {
            _message = "You left this word blank!";
        }
        if (_word.Contains(" "))
        {
            _message = "Please enter one word per Word Box! Click 'Add another word' to count more words";
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
