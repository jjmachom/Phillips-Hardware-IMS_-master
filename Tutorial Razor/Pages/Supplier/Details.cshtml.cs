using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Tutorial_Razor.Data;
using Tutorial_Razor.Models;

namespace Inventory_Management.Pages.Supplier
{
    public class DetailsModel : PageModel
    {
        private readonly Tutorial_Razor.Data.Tutorial_RazorContext _context;

        public DetailsModel(Tutorial_Razor.Data.Tutorial_RazorContext context)
        {
            _context = context;
        }

        public Suppliers Suppliers { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Suppliers = await _context.Suppliers.FirstOrDefaultAsync(m => m.supId == id);

            if (Suppliers == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
