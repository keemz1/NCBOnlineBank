using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NCBOnlineBank.Models
{
    public class PayeeAccount
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id { get; set; }
        public string Category { get; set; }
        public decimal BillAmount { get; set; }
        public int CustomerNumber { get; set; }
        public int PremiseNumber { get; set; }
        public string CustomerName { get; set; }
        public DateTime PaymentTime { get; set; }
    }
}