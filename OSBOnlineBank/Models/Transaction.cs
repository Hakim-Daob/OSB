using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OSBOnlineBank.Models
{
    public class Transaction
    {
        public int TransactionId { get; set; }
        public decimal TransactionAmount { get; set; }

        public int BankAccountId { get; set; }
        public virtual BankAccount BankAccount { get; set; }
    }
}