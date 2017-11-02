using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankofSimba.Models
{
    public class Bank
    {
        public List<BankAccount> Accounts { get; set; } = new List<BankAccount>
        {
            new BankAccount("Simba", 20000, AnimalType.Lion, true, true),
            new BankAccount("Timon", 5000, AnimalType.Meerkat, false, true),
            new BankAccount("Pumba", 5000, AnimalType.Warthog, false, true),
            new BankAccount("Rafiki", 6000, AnimalType.Mandrill, false, true),
            new BankAccount("Zazu", 4000, AnimalType.Hornbill, false, true),
            new BankAccount("Scar", 10000, AnimalType.Lion, false, false)
        };

        public void Raise()
        {
            for (int i = 0; i < Accounts.Count; i++)
            {
                if (Accounts[i].IsKing != false)
                {
                    Accounts[i].Balance += 100;
                }
                else
                {
                    Accounts[i].Balance += 10;
                }
            }
        }
    }
}
