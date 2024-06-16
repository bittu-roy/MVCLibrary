using Microsoft.CodeAnalysis.Elfie.Diagnostics;
using Microsoft.EntityFrameworkCore;
using MVCLibrary.Data;

namespace MVCLibrary.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using(var context= new LibraryContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<LibraryContext>>()))
            {
                if(context.Book.Any())
                {
                    return;
                }
                context.Book.AddRange(
                    new Book { Title = "The Song of Ice and Fire", CallNumber = "ADX 2299" },
                    new Book { Title = "Harry Potter", CallNumber = "ADX 2300" }
                    );
                context.SaveChanges();
            }
            
        }
    }
}
