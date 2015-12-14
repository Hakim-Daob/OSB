using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace OSBOnlineBank.Models
{
    public class BankAccount
    {
        public int BankAccountId { get; set; }
        public string AccountNumber { get; set; }

        public decimal Balance { get; set; }
       // public virtual BankUser BankUser { get; set; }
        public int BankUserId { get; set; }
        public virtual BankUser BankUser { get; set; }
        public virtual ICollection<Transaction> Transactions { get; set; }


    }
}