using Microsoft.AspNet.Identity.EntityFramework;
using NCBOnlineBank.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WebServices.Models;

namespace NCBOnlineBank.Domain
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext() : base("OnlineBankConnection1", throwIfV1Schema: false)
        {
            Configuration.ProxyCreationEnabled = false;
            Configuration.LazyLoadingEnabled = false;
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
        public DbSet<AccountInfo> Payee { get; set; }
        public DbSet<CustomerPayee> Payment { get; set; }
        public DbSet<PayeePayment> PayeeBill { get; set; }
        public DbSet<PayeeAccount> PayeeAccounts { get; set; }
        public DbSet<TransactionHistory> Transactions { get; set; }
        public DbSet<AccountTransaction> AccountTransactions { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}