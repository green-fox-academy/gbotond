using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TeamManagerApp.Repositories;
using TeamManagerApp.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TeamManagerApp.Controllers
{
    [Route("/home")]
    public class HomeController : Controller
    {
        TeamManagerRepository TeamManagerRepository;

        public HomeController(TeamManagerRepository teamManagerRepository)
        {
            TeamManagerRepository = teamManagerRepository;
        }

        [HttpPost]
        [Route("/home")]
        public IActionResult LoginHandler()
        {
            return RedirectToAction("home");
        }

        [HttpGet]
        [Route("/home")]
        public IActionResult Home()
        {
            return View(TeamManagerRepository.GetPost());
        }

        [HttpPost]
        [Route("/teaminfo")]
        public IActionResult TeamInfo()
        {
            return RedirectToAction("teaminfo");
        }

        [HttpGet]
        [Route("/teaminfo")]
        public IActionResult TeamInformation()
        {
            return View(TeamManagerRepository.GetTeam());
        }

        [Route("/teaminfo/add")]
        [HttpGet]
        public IActionResult Add()
        {
            return View(new Player());
        }

        [Route("/teaminfo/add")]
        [HttpPost]
        public IActionResult Add(Player player)
        {
            TeamManagerRepository.AddPlayer(player);
            return RedirectToAction("TeamInformation");
        }


        [Route("/{name}/delete")]
        [HttpPost]
        public IActionResult Delete(string name)
        {
            TeamManagerRepository.DeletePlayer(name);
            return RedirectToAction("TeamInformation");
        }
    }
}
