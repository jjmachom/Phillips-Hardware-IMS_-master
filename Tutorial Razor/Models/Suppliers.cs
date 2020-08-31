using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Tutorial_Razor.Models
{
    public class Suppliers
    {

        [Key]
        [Display(Name = "Product ID")]
        public int supId { get; set; }
        [Required(ErrorMessage = "Please enter a Supplier Name")]
        [Display(Name = "Supplier")]
        public string SupplierName { get; set; }

        [Required(ErrorMessage = "Please enter a Supplier Name")]
        [Display(Name = "Item Name")]
        public string ProductName { get; set; }

        [DataType(DataType.Currency)]
        [Display(Name = "cost")]
        public Double cost { get; set; }

    }
}
