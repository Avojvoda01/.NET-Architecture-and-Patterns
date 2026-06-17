using LayeredArchitecture.Data;
using LayeredArchitecture.Models;
using Microsoft.EntityFrameworkCore;

namespace LayeredArchitecture.Repositories
{
    public class BookRepository(AppDbContext db) : IBookRepository
    {
        public async Task<Book?> GetBookAsync(int id)
        {
            var book = db.Books.FirstOrDefaultAsync(x => x.Id == id);
            return await book;
        }

        public Task<List<Book>> GetBooksAsync()
        {
            var books = db.Books.ToListAsync();
            return books;
        }

        public async Task<Book> CreateBookAsync(Book book)
        {
            await db.Books.AddAsync(book);
            await db.SaveChangesAsync();
            return book;
        }
    }
}
