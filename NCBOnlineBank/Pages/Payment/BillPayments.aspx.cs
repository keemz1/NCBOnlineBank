using Microsoft.AspNet.Identity;
using NCBOnlineBank.Domain;
using NCBOnlineBank.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NCBOnlineBank.Pages.Payment
{
    public partial class BillPayments : System.Web.UI.Page
    {
        private List<CustomerPayee> customerPayees;

        private List<PayeePayment> payments = new List<PayeePayment>();

        private List<string> selectedPayees = new List<string>();

        private WebEndpoint1.WebService1 webService;

        private static decimal total;
        private static decimal Amount;


        protected void Page_Load(object sender, EventArgs e)
        {
            webService = new WebEndpoint1.WebService1();

            if (!User.Identity.IsAuthenticated)
            {
                Response.Redirect("/Pages/Account/Login.aspx", true);
            }

            if (!IsPostBack)
            {
                LoadPayee();
            }
        }

        protected void btnAddPayee_ServerClick(object sender, EventArgs e)
        {
            Response.Redirect("/Pages/Payment/AddPayee.aspx");
        }

        protected void btngotoPayment_Click(object sender, EventArgs e)
        {

        }

        public void LoadPayee()
        {
            using (var context = new ApplicationDbContext())
            {
                var user = HttpContext.Current.User;
                string id = Guid.Parse(user.Identity.GetUserId()).ToString();
                var item = context.Users.Where(x => x.Id == id).First();

                customerPayees = context.Payment.Where(c => c.AccountNumber == item.AccountNumber.ToString()).ToList();
                payeeGridView.DataSource = customerPayees;
                payeeGridView.DataBind();
            }
        }


        protected void textBoxAmount_TextChanged(object sender, EventArgs e)
        {
            var txt = (TextBox)sender;
            total = total + Convert.ToDecimal(txt.Text);
            if (txt.Text == null)
            {
                total = Convert.ToDecimal(0);
            }
            else if (txt.Text != null)
            {
                Amount = Convert.ToDecimal(txt.Text);
            }
        }

        protected void payeeGridView_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            GridView gv = (GridView)sender;
            GridViewRow gvRow = gv.Rows[e.RowIndex];
            TextBox tb = (TextBox)gvRow.FindControl("txtBoxAmount");
        }

        protected void btnConfirm_ServerClick(object sender, EventArgs e)
        {
            using (var context = new ApplicationDbContext())
            {
                if (Amount < 1)
                {
                    return;
                }

                var user = HttpContext.Current.User;
                string id = Guid.Parse(user.Identity.GetUserId()).ToString();
                var item = context.Users.Where(x => x.Id == id).First();
                var cusNumber = item.AccountNumber.ToString();
                var customer = context.Payment.Where(c => c.AccountNumber == cusNumber)
                    .FirstOrDefault();
                var amount = Convert.ToDecimal(Amount);

                webService.MakePayment(item.AccountNumber, customer.PremiseNumber,
                customer.Category, customer.CustomerName, customer.PayeeId, Amount);
            };
        }
    }
}