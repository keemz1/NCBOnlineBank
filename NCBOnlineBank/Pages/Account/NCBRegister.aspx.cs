using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using NCBOnlineBank.Domain;
using NCBOnlineBank.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NCBOnlineBank.Pages.Account
{
    public partial class NCBRegister : System.Web.UI.Page
    {
        public IList<string> Names { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                var manager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(new ApplicationDbContext()));

                if (manager.FindByName(txtUserName.Text) == null &&
                    manager.FindByName(txtUserName.Text) == null &&
                    manager.FindByEmail(txtUserName.Text) == null)
                {
                   
                    var user = new ApplicationUser()
                    {
                        UserName = txtUserName.Text,
                        Email = txtemail.Text,
                        EmailConfirmed = true,
                        FirstName = txtfname.Text,
                        LastName = txtlname.Text,
                        Address1 = txtaddress.Text,
                        //Address2 = txtcity.Text,
                        PhoneNumber = txtphonenum.Text,
                    };

                    manager.Create(user, txtpassword.Text);
                    manager.FindByName(txtUserName.Text);
                    manager.AddToRole(user.Id, "Customer");
                    Response.Redirect("/Pages/Site/Home.aspx");
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}