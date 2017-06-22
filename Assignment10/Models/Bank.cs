using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Assignment10.Models
{
    public class Bank
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string ClearingNumber { get; set; }
        public Category Category { get; set; }

    }

    public enum Category
    {
        Nordea,
        Swedbank,
        Handelsbanken,
        SEB
    }
}