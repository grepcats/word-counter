using Microsoft.AspNetCore.Mvc;
using WordCounter.Models;

namespace WordCounter.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("/")]
        public ActionResult Index()
        {
            RepeatCounter newCounter = new RepeatCounter("", "");
            return View("Index", newCounter);
        }

        [HttpPost("/count")]
        public ActionResult Count()
        {
            RepeatCounter newCounter = new RepeatCounter(Request.Form["word-input"], Request.Form["sentence-input"]);
            if (newCounter.IsValid())
            {
                newCounter.SetCount();
            }
            else
            {
                newCounter.SetWord("");
                newCounter.SetSentence("");
            }
            return View("Index", newCounter);
        }

    }
}
