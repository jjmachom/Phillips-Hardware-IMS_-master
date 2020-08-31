using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Tutorial_Razor.Models
{
    public class Employees 
    {
     
        [Key]
        [Display(Name = "Employee ID")]
        public int empId { get; set; }
        [Required(ErrorMessage ="Please enter First Name")]
        [Display(Name ="First Name")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Please enter Last Name")]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Please enter a Password")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        public string Role { get; set; }
        public int Active { get; set; }
        
    }
}
