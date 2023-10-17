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
    public class DetailsModel : PageModel
    {
        private readonly GAE.Data.GAEContext _context;

        public DetailsModel(GAE.Data.GAEContext context)
        {
            _context = context;
        }

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
    }
}
