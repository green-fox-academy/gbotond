using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TeamManagerApp.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TeamManagerApp.Controllers
{
    [Route("")]
    public class LoginController : Controller
    {
        [HttpGet]
        public IActionResult Login()
        {
            var team = new Team()
            {
                Name = "Green Foxes",
                Fundation = 2015
            };

            return View(team);
        }
    }
}
