using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Groot.Controllers
{
    public class GuardianController : Controller
    {
        [HttpGet]
        [Route("/groot/{message?}")]
        public IActionResult Index(string message)
        {
            if (message == null)
            {
                return BadRequest(new { error = "I am Groot!" });
            }
            else
            {
                return Json(new { received = message, translated = "I am Groot!" });
            }
        }

        //[HttpGet]
        //[Route("/yondu")]
        //public IActionResult Yondu(double distance, double time)
        //{
        //    var yondu = new Yondu() { Distance = distance, Time = time, Speed = distance / time };
        //    return Json(yondu);
        //}
    }
}
