﻿using System;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.Owin;
using Microsoft.Owin.Security.Cookies;
using Owin;

[assembly: OwinStartup(typeof(NCBOnlineBank.Startup))]

namespace NCBOnlineBank
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=316888
            app.UseCookieAuthentication(new CookieAuthenticationOptions
            {
                AuthenticationType = DefaultAuthenticationTypes.ApplicationCookie,
                LoginPath = new PathString("/Pages/Account/Login")
            });
        }

        private void ConfigureOAuthTokenGeneration(IAppBuilder app)
        {
            //// Configure the db context and user userManager to use a single instance per request
            //app.CreatePerOwinContext(ApplicationDbContext.Create);
            //app.CreatePerOwinContext<AppUserManager>(AppUserManager.Create);

            //// Plugin the OAuth bearer JSON Web Token tokens generation and Consumption will be here



        }
    }
}
