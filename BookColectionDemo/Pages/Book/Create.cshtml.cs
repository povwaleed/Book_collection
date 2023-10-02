using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using BookColectionDemo.Data;
using BookColectionDemo.Model;

namespace BookColectionDemo.Pages.Book
{
    public class CreateModel : PageModel
    {
        private readonly BookColectionDemo.Data.BookColectionDemoContext _context;

        public CreateModel(BookColectionDemo.Data.BookColectionDemoContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public BookCollections BookCollections { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.BookCollections == null || BookCollections == null)
            {
                return Page();
            }

            _context.BookCollections.Add(BookCollections);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
