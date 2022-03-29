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
    public class IndexModel : PageModel
    {
        private readonly OldGloryLPB.Data.OldGloryLPBContext _context;

        public IndexModel(OldGloryLPB.Data.OldGloryLPBContext context)
        {
            _context = context;
        }

        public IList<Order> Order { get;set; }

        public async Task OnGetAsync()
        {
            Order = await _context.Order.ToListAsync();
        }
    }
}
