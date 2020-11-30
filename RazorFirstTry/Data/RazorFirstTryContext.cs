using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RazorFirstTry.Models;

namespace RazorFirstTry.Data
{
    public class RazorFirstTryContext : DbContext
    {
        public RazorFirstTryContext (DbContextOptions<RazorFirstTryContext> options)
            : base(options)
        {
        }

        public DbSet<RazorFirstTry.Models.Movie> Movie { get; set; }
    }
}
