using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BankofSimba.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BankofSimba.Controllers
{
    public class HomeController : Controller
    {
        // GET: /<controller>/
        [Route("Simba")]
        public IActionResult Index()
        {
            BankAccount bankAccount = new BankAccount()
            {
                Name = "Simba",
                Balance = 2000,
                AnimalType = Animal.Lion

            };
            return View(bankAccount);
        }
    }
}
