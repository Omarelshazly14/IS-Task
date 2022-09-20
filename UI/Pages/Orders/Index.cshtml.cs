using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Domain;
using Microsoft.EntityFrameworkCore;

namespace UI.Pages.Orders
{
    public class IndexModel : PageModel
    {
        private readonly Infrastructure.DbContext _context;

        public IndexModel(Infrastructure.DbContext context)
        {
            _context = context;
        }

        public IList<OrderHeader> OrderHeader { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Orders != null)
            {
                List<OrderHeader> orders = await _context.Orders.ToListAsync();
            }
        }
    }
}
