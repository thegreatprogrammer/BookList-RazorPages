using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using BookListRazor.Models;
using Microsoft.EntityFrameworkCore;

namespace BookListRazor.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public IndexModel(ApplicationDbContext ctx)
        {
            _context = ctx;
        }

        public IEnumerable<Book> Books { get; set; }
        public async Task OnGet()
        {
            // Retrieving all the books in DB
            Books = await _context.Books.ToListAsync();
        }
    }
}
