using LayeredArchitecture.Models;
using Microsoft.EntityFrameworkCore;
using LayeredArchitecture.Models;

namespace LayeredArchitecture.Data
{
    public class AppDbContext:DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Book> Books {  get; set; }

    }
}
