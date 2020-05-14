using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ATM.Models
{
    public class CheckingAccount
    {
        public int Id { get; set; }
        [Required()]
        [StringLength(10, ErrorMessage = "Account number must be 10 numbers")]
        [Display(Name ="Account #")]
        public string AccountNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public float Balance { get; set; }

    }
}