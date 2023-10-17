using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using GAE.Data;
using GAE.Models;

namespace GAE.Pages.Association
{
    public class CreateModel : PageModel
    {
        private readonly GAE.Data.GAEContext _context;

        public CreateModel(GAE.Data.GAEContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Assembly Assembly { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.Assembly == null || Assembly == null)
            {
                return Page();
            }

            _context.Assembly.Add(Assembly);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
