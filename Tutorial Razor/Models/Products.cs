using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Tutorial_Razor.Models
{
    public class Products
    {

        [Key]
        [Display(Name = "Product ID")]
        public int probId { get; set; }
        [Required(ErrorMessage = "Please enter a Product Name")]
        [Display(Name = "Product Name")]
        public string ProductName { get; set; }

        [Required(ErrorMessage="Please enter a Category Name")]
        [Display(Name = "Product Catergory")]
        public string Caterory  { get; set; }


        [DataType(DataType.Currency)]
        [Display(Name = "Price")]
        public Double price { get; set; }


    }
}
