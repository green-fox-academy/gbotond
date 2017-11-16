using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CalorieTable.Repositories;
using CalorieTable.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CalorieTable.Controllers
{
    [Route("api")]
    public class ApiController : Controller
    {
        FoodRepository FoodRepository;

        public ApiController(FoodRepository foodRepository)
        {
            FoodRepository = foodRepository;
        }

        [HttpGet]
        [Route("drax")]
        public IActionResult Index()
        {
            return Json(FoodRepository.GetList());
        }

        [HttpPost]
        [Route("add")]
        public IActionResult Add([FromBody] Food food)
        {
            FoodRepository.AddFood(food);
            return Json(new { Response = "It's ok" });
        }
    }
}
