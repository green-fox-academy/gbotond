using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankofSimba.Models
{
    public class BankAccount
    {
        public string Name { get; set; }
        public decimal Balance { get; set; }
        public AnimalType AnimalType { get; set; }
        public string Currency { get; set; }
    }
}
