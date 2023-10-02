using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BookColectionDemo.Data;
using BookColectionDemo.Model;

namespace BookColectionDemo.Pages.Book
{
    public class DeleteModel : PageModel
    {
        private readonly BookColectionDemo.Data.BookColectionDemoContext _context;

        public DeleteModel(BookColectionDemo.Data.BookColectionDemoContext context)
        {
            _context = context;
        }

        [BindProperty]
      public BookCollections BookCollections { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.BookCollections == null)
            {
                return NotFound();
            }

            var bookcollections = await _context.BookCollections.FirstOrDefaultAsync(m => m.ID == id);

            if (bookcollections == null)
            {
                return NotFound();
            }
            else 
            {
                BookCollections = bookcollections;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.BookCollections == null)
            {
                return NotFound();
            }
            var bookcollections = await _context.BookCollections.FindAsync(id);

            if (bookcollections != null)
            {
                BookCollections = bookcollections;
                _context.BookCollections.Remove(BookCollections);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
