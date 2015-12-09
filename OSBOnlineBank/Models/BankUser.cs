using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using OSBOnlineBank.Models;


namespace OSBOnlineBank.Models
{
    public class BankUser
    {
   
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string EmailAddress { get; set; }

        public string Address { get; set; }

        public DateTime BirthDate { get; set; }

        public string PhoneNumber { get; set; }

        public string IdNumber { get; set; }

        public string Nationality { get; set; }

        public string Gender { get; set; }

    }
}