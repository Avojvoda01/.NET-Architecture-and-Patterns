using LayeredArchitecture.Models;
using LayeredArchitecture.DTO;

namespace LayeredArchitecture.Services
{
    public interface IBookService
    {

        public Task<Book> CreateBookAsync(CreateBook book);

    }
}
