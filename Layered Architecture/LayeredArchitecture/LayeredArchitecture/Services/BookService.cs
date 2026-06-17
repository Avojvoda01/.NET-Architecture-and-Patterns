using LayeredArchitecture.Data;
using LayeredArchitecture.Models;
using LayeredArchitecture.DTO;
using LayeredArchitecture.Repositories;

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

            repository.CreateBookAsync(newBook);
            return newBook;
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
    }
    }

