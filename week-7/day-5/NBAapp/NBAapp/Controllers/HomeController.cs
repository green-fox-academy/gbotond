using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NBAapp.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace NBAapp.Controllers
{
    public class HomeController : Controller
    {
        Team team;
    
        public HomeController(Team team)
        {
            this.team = team;
        }

        [HttpGet]
        [Route("/")]
        public IActionResult Index()
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
