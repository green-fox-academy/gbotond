using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CalorieTable.Repositories;
using CalorieTable.Models;

namespace CalorieTable.Controllers
{
    public class HomeController : Controller
    {
        FoodRepository FoodRepository;

        public HomeController(FoodRepository foodRepository)
        {
            FoodRepository = foodRepository;
        }

        [HttpGet]
        [Route("drax")]
        public IActionResult Drax()
        {
            return View(FoodRepository.GetList());
        }

        [HttpGet]
        [Route("add")]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        [Route("add")]
        public IActionResult AddFood(Food food)
        {
            FoodRepository.AddFood(food);
            return RedirectToAction("drax");
        }

        [HttpPost]
        [Route("/{id}/delete")]
        public IActionResult Delete(int id)
        {
            FoodRepository.Delete(id);
            return RedirectToAction("drax");
        }

        [HttpGet]
        [Route("/{id}/edit")]
        public IActionResult Edit([FromQuery] string Id)
        {
            int id = int.Parse(Id);
            var food = FoodRepository.GetId(id);
            return View(food);
        }

        [HttpPost]
        [Route("/{Id}/edit")]
        public IActionResult ChangeAmount(Food food)
        {
            FoodRepository.ChangeAmount(food);
            return RedirectToAction("Drax");
        }
    }
}
