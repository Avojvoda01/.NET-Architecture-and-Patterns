using LayeredArchitecture.Data;
using LayeredArchitecture.Models;
using LayeredArchitecture.DTO;
using LayeredArchitecture.Repositories;
using System.ComponentModel;

namespace LayeredArchitecture.Services
{
    public class BookService(IBookRepository repository) : IBookService
    {

        public async Task<Book> CreateBookAsync(CreateBook book)
        {
            Book newBook = new Book
            {
                Title = book.Title,
                Author = book.Author,
                YearPublished = book.YearPublished,
                isAvailable = true
            };

            return await repository.CreateBookAsync(newBook);
        }

        public async Task<List<Book>> getBooksAsync()
        {
            List<Book> books = await repository.GetBooksAsync();

            if (books == null)
            {
                return new List<Book>();
            }

            return books;
        }

        public async Task<Book> getBookByIdAsync(int id)
        {
            Book? book = await repository.GetBookAsync(id);
            if (book == null)
            {
                throw new Exception("Book not found");
            }
            return book;
           
    }
    }
}

