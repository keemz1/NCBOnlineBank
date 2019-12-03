using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NCBOnlineBank.Pages.PayeeAccounts
{
    public partial class CreateAccount : System.Web.UI.Page
    {
        private WebEndpoint1.WebService1 webService;
        protected void Page_Load(object sender, EventArgs e)
        {
            webService = new WebEndpoint1.WebService1();
        }

        protected void btnprevious_Click(object sender, EventArgs e)
        {
            Response.Redirect("/Pages/Payment/BillPayments.aspx");
        }

        protected void btnConfirm_Click(object sender, EventArgs e)
        {

        }


        public void CreateBillAccount(int customerNumber, int premiseNumber, string category)
        {
            //return webService.CreatBill(customerNumber, premiseNumber, category);
        }
    }
}