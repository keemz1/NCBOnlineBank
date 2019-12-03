using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NCBOnlineBank
{
    public class UserCredentials
    {
        public Guid getUserId()
        {
            var user = HttpContext.Current.User;
            Guid id = Guid.Parse(user.Identity.GetUserId());
            return id;
        }
    }
}