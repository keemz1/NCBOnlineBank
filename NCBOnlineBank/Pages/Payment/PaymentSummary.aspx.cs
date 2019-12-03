using NCBOnlineBank.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace NCBOnlineBank.Pages.Payment
{
    public partial class PaymentSummary : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRemove(object sender, EventArgs e)
        {

            //Guid id = getUserId();
            //GridViewRow gRow = ((GridViewRow)((HtmlButton)sender).Parent.Parent);
            //double totalFinal = (4.23 * Convert.ToDouble(gRow.Cells[3].Text)) + Convert.ToDouble(gRow.Cells[7].Text);
            //int pid = Convert.ToInt32(gRow.Cells[1].Text);
            //using (var context = new ApplicationDbContext())
            //{
            //    var item = context.PayeeBill.Where(x => x.PayeeId == pid).ToList().FirstOrDefault();
            //    context.Entry(item).State = EntityState.Deleted;
            //    //context.Cart.Remove(item);
            //    context.SaveChanges();
            //};
        }

        private Guid getUserId()
        {
            throw new NotImplementedException();
        }

        protected void btnConfirm_Click(object sender, EventArgs e)
        {
            Response.Redirect("/Pages/Payment/BillPayments.aspx");
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("/Pages/Payment/BillPayments.aspx");
        }
    }
}