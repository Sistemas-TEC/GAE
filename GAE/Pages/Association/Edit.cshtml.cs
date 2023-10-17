using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using GAE.Data;
using GAE.Models;

namespace GAE.Pages.Association
{
    public class EditModel : PageModel
    {
        private readonly GAE.Data.GAEContext _context;

        public EditModel(GAE.Data.GAEContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Assembly Assembly { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Assembly == null)
            {
                return NotFound();
            }

            var assembly =  await _context.Assembly.FirstOrDefaultAsync(m => m.AssemblyId == id);
            if (assembly == null)
            {
                return NotFound();
            }
            Assembly = assembly;
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Assembly).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AssemblyExists(Assembly.AssemblyId))
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

        private bool AssemblyExists(int id)
        {
          return (_context.Assembly?.Any(e => e.AssemblyId == id)).GetValueOrDefault();
        }
    }
}
