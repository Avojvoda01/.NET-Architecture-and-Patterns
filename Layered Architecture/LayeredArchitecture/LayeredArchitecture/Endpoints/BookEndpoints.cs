using System.Runtime.CompilerServices;
using LayeredArchitecture.Data;
using LayeredArchitecture.Repositories;
using Microsoft.EntityFrameworkCore;
using LayeredArchitecture.DTO;

namespace LayeredArchitecture.Endpoints
{
    public static class BookEndpoints
    {
        public static void MapBookEndpoints(this WebApplication app) //this is an extension method. This function MapBookEndpoints will act as a function of the WebApplication class. 
                                                                     //We can call it by app.MapBookEndpoints() in the Program.cs file. This is a common pattern for organizing endpoints in ASP.NET Core applications.
        {


            app.MapGet("/books", async (AppDbContext db) =>
            {
                return await db.Books.ToListAsync();
            });


            app.MapGet("/books/{id:int}", async (int id, AppDbContext db) => {
                var book = await db.Books.FirstOrDefaultAsync(x => x.Id == id);
                return book;
            });

            app.MapPost("/books", async (CreateBook book, AppDbContext db) =>
            {
                var newBook = new Models.Book
                {
                    Title = book.Title,
                    Author = book.Author,
                    YearPublished = book.YearPublished,
                    isAvailable = true
                };

                await db.Books.AddAsync(newBook);
                await db.SaveChangesAsync();

                return Results.Created($"/books/{newBook.Id}", newBook);

            });
        }

    }
}
