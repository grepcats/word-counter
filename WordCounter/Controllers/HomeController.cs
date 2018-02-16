using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WordCounter.Models;

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
            RepeatCounter newCounter = new RepeatCounter(Request.Form["word-input"], Request.Form["sentence-input"]);
            if (newCounter.IsValid())
            {
                newCounter.SetCount();
            }

            List<RepeatCounter> allCounters = RepeatCounter.GetAll();
            return View("Index", allCounters);
        }

    }
}
