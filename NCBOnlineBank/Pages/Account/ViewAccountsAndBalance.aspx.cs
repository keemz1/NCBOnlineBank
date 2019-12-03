using Microsoft.AspNet.Identity;
using NCBOnlineBank.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NCBOnlineBank.Pages.Account
{
    public partial class ViewAccountsAndBalance : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            if (!IsPostBack)
            {
                LoadAccount();
            }
        }


        protected void LoadAccount()
        {
            using (var context = new ApplicationDbContext())
            {
                try
                {
                    var user = HttpContext.Current.User;
                    string id = user.Identity.GetUserId().ToString();
                    var category = ddlPayee.SelectedValue;
                    var item = context.Users.Where(x => x.Id == id).First();
                    var accNumber = item.AccountNumber.ToString();
                    var accounts = context.Payment.Where(c => c.AccountNumber == accNumber
                    && c.Category == category).ToList();
                    lblbalance.Text = item.Savings.ToString();
                    accoutGrid.DataSource = accounts;
                    accoutGrid.DataBind();
                }
                catch (Exception)
                {
                    throw;
                }
                
            }
        }
    }
}