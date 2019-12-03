using Microsoft.AspNet.Identity;
using NCBOnlineBank.Models;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using NCBOnlineBank.Domain;

namespace NCBOnlineBank.Pages.Account
{
    public partial class Login : System.Web.UI.Page
    {
        UserManager<ApplicationUser> userManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(new ApplicationDbContext()));
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSignin_Click(object sender, EventArgs e)
        {
            StatusMessage.Visible = false;
            StatusMessage.Text = "";
            userManager.UserValidator = new UserValidator<ApplicationUser>(userManager);
            var userEmail = userManager.FindByEmail(txtemail.Text);
            bool confirm = userManager.CheckPassword(userEmail, txtpass.Text);
            //var user = userManager.Find(User.Identity.GetUserName(),txtpass.Text) ;
            //bool val1 = (System.Web.HttpContext.Current.User != null) && System.Web.HttpContext.Current.User.Identity.IsAuthenticated;
            //user.UseAuthentication
            if (userEmail == null || confirm == false)
            {
                StatusMessage.Visible = true;
                StatusMessage.Text = "User not found  or Incorrect password entered";
            }
            else
            {
                var authenticationManager = HttpContext.Current.GetOwinContext().Authentication;
                var userIdentity = userManager.CreateIdentity(userEmail, DefaultAuthenticationTypes.ApplicationCookie);

                authenticationManager.SignIn(new AuthenticationProperties() { IsPersistent = false }, userIdentity);
                Response.Redirect("/Pages/Site/Home.aspx");
            }
        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {

        }
    }
}