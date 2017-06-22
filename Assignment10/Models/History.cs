using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Assignment10.Models
{
    public class History
    {
        //[ForeignKey("ClearingNumber")]
        //public string ClearingNumberID { get; set; }
        //public virtual Bank Bank { get; set; }
        //[ForeignKey("AccountNumber")]
        //public int AccountNumberID { get; set; }
        //public virtual Account Account { get; set; }
        [Key]
        public int ID { get; set; }
        public virtual ICollection<Account> Account { get; set; }
        public DateTime TransactionTime { get; set; }
        public String AccountHistory { get; set; }
    }
}