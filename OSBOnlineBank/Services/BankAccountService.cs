using OSBOnlineBank.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OSBOnlineBank.Views.Services
{
    public class BankAccountService
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        public void CreateBankAccount(decimal balance, int bankUserId)
        {
            // , BankUser bankUser
            var bankAccountNumber = (12000 + db.BankAccounts.Count() + 1).ToString();
            var bankAccount = new BankAccount();

            bankAccount.AccountNumber=bankAccountNumber;
            bankAccount.Balance = balance;
            bankAccount.BankUserId=bankUserId;
          //  bankAccount.BankUser = bankUser;
         
            db.BankAccounts.Add(bankAccount);
            db.SaveChanges();
        }

    }
}