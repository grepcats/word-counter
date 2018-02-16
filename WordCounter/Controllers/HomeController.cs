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
            RepeatCounter newCounter1 = new RepeatCounter(Request.Form["word-input1"], Request.Form["sentence-input"]);
            RepeatCounter newCounter2 = new RepeatCounter(Request.Form["word-input2"], Request.Form["sentence-input"]);
            RepeatCounter newCounter3 = new RepeatCounter(Request.Form["word-input3"], Request.Form["sentence-input"]);
            List<RepeatCounter> allCounters = RepeatCounter.GetAll();
            Console.WriteLine(allCounters.Count);
            foreach (RepeatCounter counter in allCounters)
            {
                Console.WriteLine(counter.GetWord());
                if (counter.IsValid())
                {
                    counter.SetCount();
                }
            }

            return View("Index", allCounters);
        }

    }
}
