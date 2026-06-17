using System.Runtime.CompilerServices;
using LayeredArchitecture.Data;
using LayeredArchitecture.Repositories;
using Microsoft.EntityFrameworkCore;
using LayeredArchitecture.DTO;
using LayeredArchitecture.Services;

namespace LayeredArchitecture.Endpoints
{
    public static class BookEndpoints
    {
        public static void MapBookEndpoints(this WebApplication app) //this is an extension method. This function MapBookEndpoints will act as a function of the WebApplication class. 
                                                                     //We can call it by app.MapBookEndpoints() in the Program.cs file. This is a common pattern for organizing endpoints in ASP.NET Core applications.
        {


            app.MapGet("/books", async (IBookService service) =>
            {
                await service.getBooksAsync();

                return Results.Ok(await service.getBooksAsync());
            });


            app.MapGet("/books/{id:int}", async (int id, IBookService service) => {
                var book = service.getBookByIdAsync(id);

                return Results.Ok(book);
            });

            app.MapPost("/books", async (CreateBook book, IBookService service) =>
            {
                var createdBook = await service.CreateBookAsync(book);

                return Results.Created($"/books/{createdBook.Id}", createdBook);
            });
        }

    }
}
