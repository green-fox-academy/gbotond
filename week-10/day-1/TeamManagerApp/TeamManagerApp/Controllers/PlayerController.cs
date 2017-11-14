using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TeamManagerApp.Models;
using TeamManagerApp.Repositories;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TeamManagerApp.Controllers
{
    [Route("player")]
    public class PlayerController : Controller
    {
        Team team;
        TeamManagerRepository TeamManagerRepository;

        public PlayerController(Team team, TeamManagerRepository teamManagerRepository)
        {
            TeamManagerRepository = teamManagerRepository;
            this.team = team;
        }

        [HttpGet]
        [Route("profile/{Name}")]
        public IActionResult Profile(string Name)
        {
            return View(TeamManagerRepository.GetPlayer(Name));
        }

        //[HttpGet]
        //[Route("profile/{Name}")]
        //public IActionResult Stats()
        //{
        //    return View(TeamManagerRepository.GetStats());
        //}

        [HttpPost]
        [Route("update")]
        public IActionResult Upd()
        {
            return RedirectToAction("update");
        }

        [HttpGet]
        [Route("update")]
        public IActionResult Update()
        {
            return View();
        }
    }
}
