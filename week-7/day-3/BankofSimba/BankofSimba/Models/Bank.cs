﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankofSimba.Models
{
    public class Bank
    {
        public List<BankAccount> Accounts { get; set; } = new List<BankAccount>();
    }
}
