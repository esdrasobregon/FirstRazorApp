using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorFirstTry.Data;
using RazorFirstTry.Models;

namespace RazorFirstTry.Pages.Movies
{
    public class IndexModel : PageModel
    {
        private readonly RazorFirstTry.Data.RazorFirstTryContext _context;

        public IndexModel(RazorFirstTry.Data.RazorFirstTryContext context)
        {
            _context = context;
        }

        public IList<Movie> Movie { get;set; }

        public async Task OnGetAsync()
        {
            Movie = await _context.Movie.ToListAsync();
        }
    }
}
