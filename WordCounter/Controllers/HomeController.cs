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
            if (newCounter.IsEmpty())
            {
                newCounter.SetWord("");
                newCounter.SetSentence("");
            }
            else
            {
                newCounter.SetCount();
            }
            return View("Index", newCounter);
        }

    }
}
