using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Tutorial_Razor.Data;
using Tutorial_Razor.Models;

namespace Inventory_Management.Pages.Employee
{
    public class DeleteModel : PageModel
    {
        private readonly Tutorial_Razor.Data.Tutorial_RazorContext _context;

        public DeleteModel(Tutorial_Razor.Data.Tutorial_RazorContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Employees Employees { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Employees = await _context.Employees.FirstOrDefaultAsync(m => m.empId == id);

            if (Employees == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Employees = await _context.Employees.FindAsync(id);

            if (Employees != null)
            {
                _context.Employees.Remove(Employees);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
