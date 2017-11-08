using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RestBackendApp.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RestBackendApp.Controllers
{
    public class HomeController : Controller
    {
        [Route("/")]
        public IActionResult Index()
        {
            return File("index.html", "text/html");
        }

        [HttpGet]
        [Route("/doubling")]
        public IActionResult Doubling(int? input)
        {
            if (input == null)
            {
                return Json(new { error = "Please provide an input!" });
            }
            return Json(new { received = input, result = input * 2 });
        }

        [HttpGet]
        [Route("/greeter")]
        public IActionResult Greeter(string name, string title)
        {
            if (name == null)
            {
                return Json(new { error = "Please provide a name!" });
            }
            else if (title == null)
            {
                return Json(new { error = "Please provide a title!" });
            }
            else
            {
                return Json(new { welcome_message = $"Oh, hi there {name}, my dear {title}!" });
            }
        }

        [HttpGet]
        [Route("/appenda/{appendable}")]
        public IActionResult AppendA(string appendable)
        {
            return Json(new { appended = $"{appendable}a" });
        }

        [HttpGet]
        [Route("/appenda/")]
        public IActionResult Append()
        {
            return NotFound();
        }

        [HttpPost]
        [Route("/dountil/{what}")]
        [Route("/dountil/")]
        public IActionResult DoUntil([FromBody] UntilValue untilValue, string what)
        {
            if (what == "sum")
            {
                int sum = 0;
                for (int i = 1; i < untilValue.Until + 1; i++)
                {
                    sum += i;
                }
                return Json(new { result = sum });
            }
            else if (what == "factor")
            {
                int factorial = 1;
                for (int i = 1; i < untilValue.Until + 1; i++)
                {
                    factorial *= i;
                }
                return Json(new { result = factorial });
            }
            else
            {
                return Json(new { error = "Please provide a number!" });
            }
        }

        [HttpPost]
        [Route("/arrays")]
        public IActionResult ArrayHandler([FromBody] ArrayObject arrayObject)
        {
            if (arrayObject.Operation == "Sum")
            {
                int result = arrayObject.Sum(arrayObject.Numbers);
                return Json(new { result = result });
            }
            else if (arrayObject.Operation == "Multiply")
            {
                int result = arrayObject.Multiply(arrayObject.Numbers);
                return Json(new { result = result });
            }
            else if (arrayObject.Operation == "Double")
            {
                int[] result = arrayObject.Double(arrayObject.Numbers);
                return Json(new { result = result });
            }
            else
            {
                return Json(new { error = "Please provide what to do with the numbers!" });
            }
        }
    }
}