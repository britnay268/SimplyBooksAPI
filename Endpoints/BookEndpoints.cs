using System;
using SimplyBooksAPI.Interfaces;
using SimplyBooksAPI.Models;

namespace SimplyBooksAPI.Endpoints
{
    public static class BookEndpoints
    {

        public static void MapBookEndpoints(this IEndpointRouteBuilder routes)
        {
            var group = routes.MapGroup("/api/books").WithTags(nameof(Books));

            // Get All Books
            group.MapGet("/", async (IBookService bookService) =>
            {
                return await bookService.GetBooksAsync();
            })
            .WithOpenApi()
            .Produces<List<Books>>(StatusCodes.Status200OK);

            // Get All User's Books
            group.MapGet("/user/{userId}", async (IBookService bookService, int userId) =>
            {
                return await bookService.GetUserBooksAsync(userId);
            })
            .WithOpenApi()
            .Produces<List<Books>>(StatusCodes.Status200OK);

            // Get Books By Id
            group.MapGet("/{id}", async (IBookService bookService, Guid id) =>
            {
                var book = await bookService.GetBooksByIdAsync(id);
                if (book == null)
                {
                    return Results.NotFound();
                }
                return Results.Ok(book);
            })
            .WithOpenApi()
            .Produces<Books>(StatusCodes.Status200OK);

            // Create a Book
            group.MapPost("/", async (IBookService bookService, Books book) =>
            {
                var bookToCreate = await bookService.CreateBookAsync(book);
                return Results.Created($"/api/books/{bookToCreate.Id}", bookToCreate);
            })
            .WithOpenApi()
            .Produces<Books>(StatusCodes.Status201Created)
            .Produces(StatusCodes.Status400BadRequest);

            // Update a Book
            group.MapPut("/{id}", async (IBookService bookService, Guid id, Books book) =>
            {
                var bookToUpdate = await bookService.UpdateBookAsync(id, book);
                if (bookToUpdate == null)
                {
                    return Results.NotFound();
                }
                return Results.Ok("Book has been updated!");
            })
            .WithOpenApi()
            .Produces<Books>(StatusCodes.Status200OK)
            .Produces(StatusCodes.Status204NoContent);

            // Delete a Book
            group.MapDelete("/{id}", async (IBookService bookService, Guid id) =>
            {
                var bookToDelete = await bookService.DeleteBookAsync(id);
                if (bookToDelete == null)
                {
                    return Results.NotFound();
                }
                return Results.NoContent();
            })
            .WithOpenApi()
            .Produces<Books>(StatusCodes.Status204NoContent);
        }
    }
}
