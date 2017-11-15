using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using GreenfoxQuizApp.Models;
using GreenfoxQuizApp.Repositories;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GreenfoxQuizApp.Controllers
{
    [Route("")]
    public class HomeController : Controller
    {
        Text text;
        GreenfoxQuizAppRepository GreenfoxQuizAppRepository;

        public HomeController(Text text, GreenfoxQuizAppRepository greenfoxQuizAppRepository)
        {
            this.text = text;
            GreenfoxQuizAppRepository = greenfoxQuizAppRepository;
        }

        [HttpGet]
        [Route("questions")]
        public IActionResult Index()
        {
            return Json(GreenfoxQuizAppRepository.GetRandomList());
        }
    }
}
