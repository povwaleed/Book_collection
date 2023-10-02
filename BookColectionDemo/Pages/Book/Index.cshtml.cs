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
    public class IndexModel : PageModel
    {
        private readonly BookColectionDemo.Data.BookColectionDemoContext _context;

        public IndexModel(BookColectionDemo.Data.BookColectionDemoContext context)
        {
            _context = context;
        }

        public IList<BookCollections> BookCollections { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.BookCollections != null)
            {
                BookCollections = await _context.BookCollections.ToListAsync();
            }
        }
    }
}
