using NCBOnlineBank.Domain;
using NCBOnlineBank.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using NCBOnlineBank.WebEndpoint1;

namespace NCBOnlineBank.Pages.Payment
{
    public partial class AddPayee : System.Web.UI.Page
    {
        //private JSPEndpoint2.JPSWebService endpoint;
        private WebEndpoint1.WebService1 webService;

        protected void Page_Load(object sender, EventArgs e)
        {
            webService = new WebEndpoint1.WebService1();
        }

        protected void btnConfirm_Click(object sender, EventArgs e)
        {
            using (var context = new ApplicationDbContext())
            {
                UserCredentials userCredentials = new UserCredentials();
                string id= userCredentials.getUserId().ToString();
                var categorySelect = ddlPayee.SelectedValue;
                var item = context.Users.Where(x => x.Id == id).First();
                var accNumber = Convert.ToInt32(txtAccountNumber.Text);
                var premNumber = Convert.ToInt32(txtpremisesNumber.Text);
                var payeepay = context.Payment.Where(c => c.PayeeId == ddlPayee.SelectedIndex).ToList();
                string fullname = String.Concat(item.FirstName," ", item.LastName);
                

                var val = ValidatePayee(accNumber,premNumber,categorySelect);
                if (val == false)
                {
                    Response.Redirect("/Pages/PayeeAccounts/CreateAccount.aspx");
                }
                if (txtRSA.Text == item.PinCode)
                {
                    context.Payment.Add(new CustomerPayee
                    {
                        CustomerName = fullname,
                        PayeeId = ddlPayee.SelectedIndex,
                        AccountNumber = item.AccountNumber.ToString(),
                        PremiseNumber = premNumber,
                        Category = categorySelect
                    });
                    context.SaveChanges();
                    Response.Redirect("/Pages/Payment/BillPayments.aspx");
                }
            }
        }

        protected void btnprevious_Click(object sender, EventArgs e)
        {
            Response.Redirect("/Pages/Payment/BillPayments.aspx");
        }

        private bool ValidatePayee(int customerNumber, int premisesNumber, string category)
        {
            return webService.VerifyAccount(customerNumber, premisesNumber, category);
        }
    }
}