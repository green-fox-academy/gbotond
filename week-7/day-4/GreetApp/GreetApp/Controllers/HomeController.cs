using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using GreetApp.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GreetApp.Controllers
{
    public class HomeController : Controller
    {
        Greet greet;

        public HomeController(Greet greet)
        {
            this.greet = greet;
        }

        [HttpGet]
        [Route("/")]
        public IActionResult Index()
        {
            return View(greet);
        }

        [HttpPost]
        [Route("/")]
        public IActionResult Continue(Greet greet)
        {
            return RedirectToAction("Greet", greet);
        }

        [HttpGet]
        [Route("greet")]
        public IActionResult Greet(Greet greet)
        {
            return View(greet);
        }
    }
}
