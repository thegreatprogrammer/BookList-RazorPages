using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BookListRazor.Models;

namespace BookListRazor._Pages_Books
{
    public class IndexModel : PageModel
    {
        private readonly BookListRazor.Models.ApplicationDbContext _context;

        public IndexModel(BookListRazor.Models.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Book> Book { get;set; }

        public async Task OnGetAsync()
        {
            Book = await _context.Books.ToListAsync();
        }
    }
}
