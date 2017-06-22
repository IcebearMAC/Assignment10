using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Assignment10.Models
{
    public class Customer
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Required]
        [StringLength(10, ErrorMessage = " Please use the ten(10) digits in SSN")]
        public string SSN { get; set; }
        [Required]
        public string Name { get; set; }
        public virtual ICollection<Account> Account { get; set; }

    }
}