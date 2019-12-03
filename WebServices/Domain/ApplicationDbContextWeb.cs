using Microsoft.AspNet.Identity.EntityFramework;
using WebServices.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Configuration;

namespace NCBOnlineBank.Domain
{
    public class ApplicationDbContextWeb : DbContext
    {
        public ApplicationDbContextWeb() : base("Services")
        {

        }

        public static ApplicationDbContextWeb Create()
        {
            return new ApplicationDbContextWeb();
        }
        //public DbSet<PayeeAccount> PayeeAccounts { get; set; }

    }
}