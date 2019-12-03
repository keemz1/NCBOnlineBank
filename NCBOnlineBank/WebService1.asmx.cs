using Microsoft.AspNet.Identity;
using NCBOnlineBank.Domain;
using NCBOnlineBank.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Services;


namespace NCBOnlineBank
{
    /// <summary>
    /// Summary description for JPSWebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        [WebMethod]
        public bool VerifyAccount(int customerNumber, int premiseNumber, string category)
        {
            using (var context = new ApplicationDbContext())
            {
                var user = HttpContext.Current.User;
                int id = Convert.ToInt32(user.Identity.GetUserId());
                var items = context.PayeeAccounts
                    .Where(c => c.CustomerNumber == customerNumber && c.Category == category && c.PremiseNumber == premiseNumber).ToList();
                var result = items.Count();
                if (result > 0)
                {
                    return true;
                }
            }

            return false;
        }

        [WebMethod]
        public void MakePayment(int customerNumber, int premiseNumber,
            string category, string customerName, int payeeId, decimal payAmount)
        {
            using (var context = new ApplicationDbContext())
            {
                context.PayeeBill.Add(new PayeePayment
                {
                    CustomerNumber = customerNumber,
                    Category = category,
                    CustomerName = customerName,
                    PaymentTime = DateTime.Now,
                    PremiseNumber = premiseNumber,
                    PaymentAmount = payAmount,
                    PayeeId = payeeId,
                });
                context.SaveChanges();

                //JPS or NWC Bill Change
                var item = context.PayeeAccounts
                    .Where(x => x.CustomerNumber == customerNumber && x.Category == category && x.PremiseNumber == premiseNumber)
                    .FirstOrDefault();
                var pay = payAmount + item.BillAmount;
                item.BillAmount = pay;
                context.SaveChanges();

                var accountInfo = context.Users
                    .Where(x => x.AccountNumber == customerNumber )
                    .FirstOrDefault();
                var vaccount = accountInfo.Savings - payAmount;
                accountInfo.Savings = vaccount;
                context.SaveChanges();

                TransactionBank(customerNumber, premiseNumber, category, payeeId, payAmount);
                TransactionAccount(customerNumber, premiseNumber, category, payeeId, payAmount);
            };
        }

        [WebMethod]
        public void TransactionBank(int customerNumber, int premiseNumber,
            string category, int payeeId, decimal transactionAmount)
        {

            using (var context = new ApplicationDbContext())
            {
                context.Transactions.Add(new TransactionHistory
                {
                    CustomerNumber = customerNumber,
                    Category = category,
                    PaymentTime = DateTime.Now,
                    PremiseNumber = premiseNumber,
                    TranactionAmount = transactionAmount,
                    PayeeId = payeeId
                });
                context.SaveChanges();
            };
        }

        public void TransactionAccount(int customerNumber, int premiseNumber,
            string category, int payeeId, decimal transactionAmount)
        {

            using (var context = new ApplicationDbContext())
            {
                //JPS or NWC Bill Transactions
                context.AccountTransactions.Add(new AccountTransaction
                {
                    CustomerNumber = customerNumber,
                    Category = category,
                    PaymentTime = DateTime.Now,
                    PremiseNumber = premiseNumber,
                    TranactionAmount = transactionAmount,
                });
                context.SaveChanges();
            };
        }

        public void ViewTransactionAccountHistory(int customerNumber, int premiseNumber,string category)
        {
            using (var context = new ApplicationDbContext())
            {
                //JPS or NWC Bill Transactions
                var user = HttpContext.Current.User;
                string id = Guid.Parse(user.Identity.GetUserId()).ToString();
                var item = context.Users.Where(x => x.Id == id).First();

                var customerPayees = context.AccountTransactions.Where(c => c.CustomerNumber == customerNumber
                && c.Category == category).ToList();
                //payeeGridView.DataSource = customerPayees;
                //payeeGridView.DataBind();
            };
        }

        public void ViewTransactionBankHistory(int customerNumber)
        {
            using (var context = new ApplicationDbContext())
            {
                //JPS or NWC Bill Transactions
                var user = HttpContext.Current.User;
                string id = Guid.Parse(user.Identity.GetUserId()).ToString();
                var item = context.Users.Where(x => x.Id == id).First();

                var customerPayees = context.Transactions.Where(c => c.CustomerNumber == customerNumber).ToList();
                //payeeGridView.DataSource = customerPayees;
                //payeeGridView.DataBind();
            };
        }

        [WebMethod]
        public void CreateBill(int customerNumber, int premiseNumber,string category)
        {

            using (var context = new ApplicationDbContext())
            {
                context.PayeeAccounts.Add(new PayeeAccount
                {
                    CustomerNumber = customerNumber,
                    PremiseNumber = premiseNumber,
                    Category = category

                });
                context.SaveChanges();
            };
        }
    }
}
