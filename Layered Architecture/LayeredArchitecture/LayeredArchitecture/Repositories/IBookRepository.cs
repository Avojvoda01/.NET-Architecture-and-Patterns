using LayeredArchitecture.Data;
using LayeredArchitecture.Models;

namespace LayeredArchitecture.Repositories
{
    public interface IBookRepository
    {
        public Task<List<Book>> GetBooksAsync();
        public Task<Book?> GetBookAsync(int id);

        public Task<Book> CreateBookAsync(Book book);



    }
}
