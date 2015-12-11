using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace OSBOnlineBank.Models
{
    public class BankAccount
    {
        public int Id { get; set; }
        public string AccountNumber { get; set; }

        public double Balance { get; set; }

        public virtual BankUser BankUser { get; set; }


        public string BankUserId { get; set; }

    }
}