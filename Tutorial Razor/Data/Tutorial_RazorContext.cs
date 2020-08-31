using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Tutorial_Razor.Models;

namespace Tutorial_Razor.Data
{
    public class Tutorial_RazorContext : DbContext
    {
        public Tutorial_RazorContext (DbContextOptions<Tutorial_RazorContext> options)
            : base(options)
        {
        }

        public DbSet<Tutorial_Razor.Models.Customers> Customers { get; set; }

        public DbSet<Tutorial_Razor.Models.Employees> Employees { get; set; }

        public DbSet<Tutorial_Razor.Models.Products> Products { get; set; }

        public DbSet<Tutorial_Razor.Models.Suppliers> Suppliers { get; set; }
    }
}
