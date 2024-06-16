using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MVCLibrary.Models;

namespace MVCLibrary.Data
{
    public class LibraryContext : DbContext
    {
        public LibraryContext (DbContextOptions<LibraryContext> options)
            : base(options)
        {
        }

        //Book-> Database Table and it will have rows in it.
        public DbSet<MVCLibrary.Models.Book> Book { get; set; } = default!;
    }
}
