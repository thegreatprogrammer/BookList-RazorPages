using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using BookListRazor.Models;

namespace BookListRazor._Pages_Books
{
    public class CreateModel : PageModel
    {
        private readonly BookListRazor.Models.ApplicationDbContext _context;

        public CreateModel(BookListRazor.Models.ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        // Empty book object
        [BindProperty]
        public Book Book { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            await _context.Books.AddAsync(Book);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
