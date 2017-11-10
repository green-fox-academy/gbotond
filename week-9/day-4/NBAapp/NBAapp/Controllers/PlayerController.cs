using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NBAapp.Models;
using NBAapp.Repositories;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace NBAapp.Controllers
{
    [Route("player")]
    public class PlayerController : Controller
    {
        Team team;
        NBARepository NBARepository;

        public PlayerController(Team team, NBARepository nBARepository)
        {
            NBARepository = nBARepository;
            this.team = team;
        }

        [HttpGet]
        [Route("profile/{Name}")]
        public IActionResult Profile(string Name)
        {
            return View(NBARepository.GetPlayer(Name));
        }

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