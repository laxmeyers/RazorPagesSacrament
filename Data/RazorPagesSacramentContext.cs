using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RazorPagesSacrament.Models;

namespace RazorPagesSacrament.Data
{
    public class RazorPagesSacramentContext : DbContext
    {
        public RazorPagesSacramentContext (DbContextOptions<RazorPagesSacramentContext> options)
            : base(options)
        {
        }

        public DbSet<RazorPagesSacrament.Models.Meeting> Meeting { get; set; }
    }
}
