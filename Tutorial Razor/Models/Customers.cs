using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Tutorial_Razor.Models
{
    public class Customers
    {

        [Key]
        [Display(Name ="Customer ID")]
        public int CustomerId { get; set; }
        [Display(Name = "First Name")]
        [Required]
        public  string  FirstName { get; set; }
        [Display(Name = "Last Name")]
        [Required]
        public string LastName { get; set; }
        [Display(Name = "Telephone Number")]
        [Required]
        public string TelePhone { get; set; }
        [Display(Name = "Full Name")]
        public string Fullname
        {

            get { return FirstName + " " + LastName; }
        }
    }
}
