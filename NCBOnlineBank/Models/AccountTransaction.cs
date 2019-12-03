using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NCBOnlineBank.Models
{
    public class AccountTransaction
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id { get; set; }
        public string Category { get; set; }
        public decimal TranactionAmount { get; set; }
        public DateTime PaymentTime { get; set; }
        public int CustomerNumber { get; set; }
        public int PremiseNumber { get; set; }
    }
}