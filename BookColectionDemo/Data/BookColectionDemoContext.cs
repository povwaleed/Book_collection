using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BookColectionDemo.Model;

namespace BookColectionDemo.Data
{
    public class BookColectionDemoContext : DbContext
    {
        public BookColectionDemoContext (DbContextOptions<BookColectionDemoContext> options)
            : base(options)
        {
        }

        public DbSet<BookColectionDemo.Model.BookCollections> BookCollections { get; set; } = default!;
    }
}
