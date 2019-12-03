using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NCBOnlineBank.Models
{
    public class CustomerPayee
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int CustomerPayeeID { get; set; }
        public int PayeeId { get; set; }
        public string CustomerName { get; set; }
        public int PremiseNumber { get; set; }
        public string Category { get; set; }
        public string AccountNumber { get; set; }
    }
}