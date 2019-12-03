using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NCBOnlineBank.Models
{
    public class ApplicationUser : IdentityUser
    {
        public int AccountNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public int PremiseNumber { get; set; }
        public decimal Savings { get; set; }
        public string Currency { get; set; }
        public string PinCode { get; set; }
    }
}