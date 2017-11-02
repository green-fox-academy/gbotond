using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AnagramApp.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AnagramApp.Controllers
{
    public class HomeController : Controller
    {
        Anagram anagram;

        public HomeController(Anagram anagram)
        {
            this.anagram = anagram;
        }

        [HttpGet]
        [Route("/")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [Route("Anagram")]
        public IActionResult IsAnagram(string word1, string word2)
        {
            anagram.firstWord = word1;
            anagram.secondWord = word2;

            return RedirectToAction("anagram");
        }

        [HttpGet]
        [Route("Anagram")]
        public IActionResult Anagram()
        {
            return View(anagram);
        }
    }
}
