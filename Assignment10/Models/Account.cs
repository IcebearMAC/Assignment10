using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Assignment10.Models
{
    public class Account
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Required]
        public int AccountNumber { get; set; }
        [ForeignKey("Bank")]
        public string ClearingNumber { get; set; }
        public virtual Bank Bank { get; set; }
        public virtual ICollection<Customer> Customer { get; set; }
        public double Balance { get; set; }

    }
}