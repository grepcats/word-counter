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

    }
}
