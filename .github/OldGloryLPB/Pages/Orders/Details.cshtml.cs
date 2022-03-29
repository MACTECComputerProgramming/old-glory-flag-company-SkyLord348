#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using OldGloryLPB.Data;
using OldGloryLPB.Models;

namespace OldGloryLPB.Pages.Orders
{
    public class DetailsModel : PageModel
    {
        private readonly OldGloryLPB.Data.OldGloryLPBContext _context;

        public DetailsModel(OldGloryLPB.Data.OldGloryLPBContext context)
        {
            _context = context;
        }

        public Order Order { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Order = await _context.Order.FirstOrDefaultAsync(m => m.OrderId == id);

            if (Order == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
