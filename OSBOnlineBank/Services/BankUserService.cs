using OSBOnlineBank.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OSBOnlineBank.Views.Services
{
    public class BankUserService
    {
        private ApplicationDbContext db= new ApplicationDbContext();


        public BankUser CreateBankUser(string firstName, string lastName, string email, string address, DateTime birthDate, string phoneNumber, string personalId, string nationality, string gender, string applicationUserId)
        {
            BankUser bankUser = new BankUser();

            bankUser.FirstName=firstName;
            bankUser.LastName=lastName;
            bankUser.EmailAddress=email;
            bankUser.Address=address;
            bankUser.BirthDate=birthDate;
            bankUser.PhoneNumber=phoneNumber;
            bankUser.PersonalId = personalId;
            bankUser.Nationality=nationality;
            bankUser.Gender=gender;
            bankUser.ApplicationUserId = applicationUserId;

            db.BankUsers.Add(bankUser);
            db.SaveChanges();
            return bankUser; 
        }
    }
}