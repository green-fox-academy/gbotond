using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankofSimba.Models
{
    public class BankAccount
    {
        public string Name { get; set; }
        public double Balance { get; set; }
        public AnimalType AnimalType { get; set; }
        public string Currency { get; set; }
        public bool IsKing { get; set; }
        public bool IsGood { get; set; }

        public BankAccount(string name, double balance, AnimalType animaltype, bool isKing, bool isGood)
        {
            Name = name;
            Balance = balance;
            AnimalType = animaltype;
            IsKing = isKing;
            IsGood = isGood;
        }
    }
}
