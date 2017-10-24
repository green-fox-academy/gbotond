using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TutorialExercise.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TutorialExercise.Controllers
{
    [Route("web")]
    public class WebController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        [Route("greeting")]
        public IActionResult Greeting(string name)
        {
            Startup.numberOfApiCalls++;
            var greeting = new Greeting()
            {
                Id = Startup.numberOfApiCalls,
                content = name
            };

            return View(greeting);
        }
    }
}
