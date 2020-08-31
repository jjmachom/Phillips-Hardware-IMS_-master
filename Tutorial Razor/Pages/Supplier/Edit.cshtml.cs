using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Tutorial_Razor.Data;
using Tutorial_Razor.Models;

namespace Inventory_Management.Pages.Supplier
{
    public class EditModel : PageModel
    {
        private readonly Tutorial_Razor.Data.Tutorial_RazorContext _context;

        public EditModel(Tutorial_Razor.Data.Tutorial_RazorContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Suppliers).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SuppliersExists(Suppliers.supId))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool SuppliersExists(int id)
        {
            return _context.Suppliers.Any(e => e.supId == id);
        }
    }
}
