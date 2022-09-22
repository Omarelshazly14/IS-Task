using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Domain;
using Infrastructure;
using Microsoft.EntityFrameworkCore;


namespace UI.Pages.Orders
{
    public class DeleteModel : PageModel
    {
        private readonly Context _context;

        public DeleteModel(Context context)
        {
            _context = context;
        }

        [BindProperty]
      public OrderHeader OrderHeader { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Orders == null)
            {
                return NotFound();
            }

            var orderheader = await _context.Orders.FirstOrDefaultAsync(m => m.Id == id);

            if (orderheader == null)
            {
                return NotFound();
            }
            else 
            {
                OrderHeader = orderheader;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.Orders == null)
            {
                return NotFound();
            }
            var orderheader = await _context.Orders.FindAsync(id);

            if (orderheader != null)
            {
                OrderHeader = orderheader;
                _context.Orders.Remove(OrderHeader);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
