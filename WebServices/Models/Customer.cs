using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebServices.Models
{
    public class Customer : IdentityUser
    {
        public int AccountNumber { get; set; }
        public string CustomerName { get; set; }
        public int PremiseNumber { get; set; }
    }
}