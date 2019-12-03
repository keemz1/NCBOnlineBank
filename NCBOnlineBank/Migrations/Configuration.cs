namespace NCBOnlineBank.Migrations
{
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using NCBOnlineBank.Domain;
    using NCBOnlineBank.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<NCBOnlineBank.Domain.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(NCBOnlineBank.Domain.ApplicationDbContext context)
        {
            var manager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(new ApplicationDbContext()));

            var user = new ApplicationUser()
            {
                UserName = "keemz23",
                Email = "keemz@mymail.com",
                EmailConfirmed = true,
                FirstName = "keemz",
                LastName = "henny",
                Address1 = "1 King Ave",
                PhoneNumber = "999-999-9999",
                Savings = Convert.ToDecimal(5000000),
                AccountNumber = 111111,
                PinCode = "1234"
            };

            manager.Create(user, "password");
        }
    }
}
