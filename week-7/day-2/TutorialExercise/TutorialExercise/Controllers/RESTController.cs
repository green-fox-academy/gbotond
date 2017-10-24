using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TutorialExercise.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TutorialExercise.Controllers
{
    [Route("api")]
    public class RESTController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        [Route("greeting")]
        public IActionResult Greeting(string name)
        {
            return new JsonResult(new Greeting { Id = 1 , content = "Hello " + name });
        }
    }
}
