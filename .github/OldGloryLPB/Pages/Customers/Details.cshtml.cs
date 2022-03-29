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

namespace OldGloryLPB.Pages.Customers
{
    public class DetailsModel : PageModel
    {
        private readonly OldGloryLPB.Data.OldGloryLPBContext _context;

        public DetailsModel(OldGloryLPB.Data.OldGloryLPBContext context)
        {
            _context = context;
        }

        public Customer Customer { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Customer = await _context.Customer.FirstOrDefaultAsync(m => m.Id == id);

            if (Customer == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
