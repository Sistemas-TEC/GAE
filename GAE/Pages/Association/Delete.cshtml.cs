using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using GAE.Data;
using GAE.Models;

namespace GAE.Pages.Association
{
    public class DeleteModel : PageModel
    {
        private readonly GAE.Data.GAEContext _context;

        public DeleteModel(GAE.Data.GAEContext context)
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

            var assembly = await _context.Assembly.FirstOrDefaultAsync(m => m.AssemblyId == id);

            if (assembly == null)
            {
                return NotFound();
            }
            else 
            {
                Assembly = assembly;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.Assembly == null)
            {
                return NotFound();
            }
            var assembly = await _context.Assembly.FindAsync(id);

            if (assembly != null)
            {
                Assembly = assembly;
                _context.Assembly.Remove(Assembly);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
