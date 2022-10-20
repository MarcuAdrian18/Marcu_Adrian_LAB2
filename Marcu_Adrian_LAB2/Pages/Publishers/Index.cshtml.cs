using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Marcu_Adrian_LAB2.Data;
using Marcu_Adrian_LAB2.Models;

namespace Marcu_Adrian_LAB2.Pages.Publishers
{
    public class IndexModel : PageModel
    {
        private readonly Marcu_Adrian_LAB2.Data.Marcu_Adrian_LAB2Context _context;

        public IndexModel(Marcu_Adrian_LAB2.Data.Marcu_Adrian_LAB2Context context)
        {
            _context = context;
        }

        public IList<Publisher> Publisher { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Publisher != null)
            {
                Publisher = await _context.Publisher.ToListAsync();
            }
        }
    }
}
