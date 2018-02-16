using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WordCounter.Models;
using System;

namespace WordCounter.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("/")]
        public ActionResult Index()
        {
            List<RepeatCounter> allCounters = RepeatCounter.GetAll();
            return View("Index", allCounters);
        }

        [HttpPost("/count")]
        public ActionResult Count()
        {
            RepeatCounter.ClearAll();
            int numInputs = Request.Form["word-input"].Count;
            List<string> wordInputs = new List<string>{};
            for (int i = 0; i < numInputs; i++) {
                string newWord = Request.Form["word-input"][i];
                wordInputs.Add(newWord);
            }

            foreach (string word in wordInputs)
            {
                RepeatCounter newCounter = new RepeatCounter(word, Request.Form["sentence-input"]);
                if (newCounter.IsValid())
                {
                    newCounter.SetCount();
                }
            }

            List<RepeatCounter> allCounters = RepeatCounter.GetAll();
            return View("Index", allCounters);
        }

    }
}
