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
        Bank bank;

        public HomeController(Bank bank)
        {
            this.bank = bank;
        }

        [HttpGet]
        [Route("Accounts")]
        public IActionResult AccountList()
        {
            return View(bank);
        }

        [HttpPost]
        [Route("Accounts")]
        public IActionResult MyAction()
        {
            bank.Raise();
            return RedirectToAction("accounts");
        }
    }
}
