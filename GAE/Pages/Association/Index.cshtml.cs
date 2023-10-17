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
    public class IndexModel : PageModel
    {
        private readonly GAE.Data.GAEContext _context;  

        public IndexModel(GAE.Data.GAEContext context)
        {
            _context = context;
        }

        public IList<Assembly> Assembly { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Assembly != null)
            {
                Assembly = await _context.Assembly.ToListAsync();
            }
        }
    }
}
