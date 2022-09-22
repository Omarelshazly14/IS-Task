using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Domain;
using Microsoft.EntityFrameworkCore;
using Infrastructure;

namespace UI.Pages.Orders
{
    public class IndexModel : PageModel
    {
        private readonly Context _context;

        public IndexModel(Context context)
        {
            _context = context;
        }

        public IList<OrderHeader> OrderHeader { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Orders != null)
            {
                OrderHeader = await _context.Orders.ToListAsync();
            }
        }
    }
}
