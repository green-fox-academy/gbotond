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
                AnimalType = AnimalType.Lion,
                Currency = "Zebra"
            };
            return View(bankAccount);
        }

        [Route("Accounts")]
        public IActionResult AccountList()
        {
            Bank BankOfSimba = new Bank();

            BankOfSimba.Accounts.Add(new BankAccount()
            {
                Name = "Simba",
                Balance = 2000,
                AnimalType = AnimalType.Lion,
                Currency = "Zebra",
                isKing = true,
                isGood = true
            });
            BankOfSimba.Accounts.Add(new BankAccount()
            {
                Name = "Timon",
                Balance = 5000,
                AnimalType = AnimalType.Meerkat,
                Currency = "Bug",
                isKing = false,
                isGood = true
            });
            BankOfSimba.Accounts.Add(new BankAccount()
            {
                Name = "Pumba",
                Balance = 500,
                AnimalType = AnimalType.Warthog,
                Currency = "Fruit",
                isKing = false,
                isGood = true
            });
            BankOfSimba.Accounts.Add(new BankAccount()
            {
                Name = "Rafiki",
                Balance = 3000,
                AnimalType = AnimalType.Mandrill,
                Currency = "Fruit",
                isKing = false,
                isGood = true
            });

            BankOfSimba.Accounts.Add(new BankAccount()
            {
                Name = "Zazu",
                Balance = 8000,
                AnimalType = AnimalType.Hornbill,
                Currency = "Seed",
                isKing = false,
                isGood = true
            });

            BankOfSimba.Accounts.Add(new BankAccount()
            {
                Name = "Scar",
                Balance = 1000,
                AnimalType = AnimalType.Lion,
                Currency = "Zebra",
                isKing = false,
                isGood = false
            });

            return View(BankOfSimba);
        }
    }
}
