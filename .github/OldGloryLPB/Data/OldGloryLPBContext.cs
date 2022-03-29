#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using OldGloryLPB.Models;

namespace OldGloryLPB.Data
{
    public class OldGloryLPBContext : DbContext
    {
        public OldGloryLPBContext (DbContextOptions<OldGloryLPBContext> options)
            : base(options)
        {
        }

        public DbSet<OldGloryLPB.Models.Customer> Customer { get; set; }

        public DbSet<OldGloryLPB.Models.Order> Order { get; set; }

        public DbSet<OldGloryLPB.Models.Product> Product { get; set; }
    }
}
