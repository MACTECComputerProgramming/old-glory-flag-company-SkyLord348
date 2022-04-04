#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using OldGloryLPB.Data;
using OldGloryLPB.Models;

namespace OldGloryLPB.Pages.Customers
{
    public class IndexModel : PageModel
    {
        private readonly OldGloryLPB.Data.OldGloryLPBContext _context;

        public IndexModel(OldGloryLPB.Data.OldGloryLPBContext context)
        {
            _context = context;
        }

        public IList<Customer> Customer { get;set; }
        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }
        public SelectList Customers { get; set; }
        [BindProperty(SupportsGet = true)]
        public string CustomerName { get; set; }


        public async Task OnGetAsync()
        {
            var customers = from c in _context.Customer
                            select c;
            if (!string.IsNullOrEmpty(SearchString))
            {
                customers = customers.Where(s => s.Title.Contains(SearchString));
            }

            Customer = await _context.Customer.ToListAsync();
        }
    }
}
