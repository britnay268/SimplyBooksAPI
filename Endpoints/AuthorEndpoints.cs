using SimplyBooksAPI.Interfaces;
using SimplyBooksAPI.Models;
using SimplyBooksAPI.Services;

namespace SimplyBooksAPI.Endpoints
{
    public static class AuthorEndpoints
    {
        public static void MapAuthorEndpoints(this IEndpointRouteBuilder routes)
        {
            var group = routes.MapGroup("/api").WithTags(nameof(Authors));

            // Get All Authors
            group.MapGet("/authors", async (IAuthorService authorService) =>
            {
                return await authorService.GetAuthorsAsync();
            })
            .WithOpenApi()
            .Produces<List<Authors>>(StatusCodes.Status200OK);

            // Get All User's Authors
            group.MapGet("/authors/user/{userId}", async (IAuthorService authorService, int userId) =>
            {
                return await authorService.GetUserAuthorsAsync(userId);
            })
            .WithOpenApi()
            .Produces<List<Authors>>(StatusCodes.Status200OK);

            // Get Authors by Id
            group.MapGet("/authors/{id}", async (IAuthorService authorService, int id) =>
            {
                var author = await authorService.GetAuthorByIdAsync(id);
                if (author == null)
                {
                    return Results.NotFound();
                }
                return Results.Ok(author);
            })
            .WithOpenApi()
            .Produces<Authors>(StatusCodes.Status200OK);

            // Get Favorite Authors
            group.MapGet("/authors/favorite", async (IAuthorService authorService) =>
            {
                return await authorService.GetFavoriteAuthorsAsync();
            })
           .WithOpenApi()
           .Produces<List<Authors>>(StatusCodes.Status200OK);

            // Create Author
            group.MapPost("/authors", async (IAuthorService authorService, Authors author) =>
            {
                var authorToCreate = await authorService.CreateAuthorAsync(author);
                return Results.Created($"/api/authors/{authorToCreate.Id}", authorToCreate);
            })
            .WithOpenApi()
            .Produces<Authors>(StatusCodes.Status201Created)
            .Produces(StatusCodes.Status400BadRequest);

            // Update Author
            group.MapPut("/authors/{id}", async (IAuthorService authorService, int id, Authors author) =>
            {
                var authorToUpdate = await authorService.UpdateAuthorAsync(id, author);
                if (authorToUpdate == null)
                {
                    return Results.NotFound();
                }
                return Results.Ok("Author has been updated!");
            })
            .WithOpenApi()
            .Produces<Books>(StatusCodes.Status200OK)
            .Produces(StatusCodes.Status204NoContent);

            // Delete Single Author and Books
            group.MapDelete("/authors/{id}", async (IAuthorService authorService, int id) =>
            {
                var authorToDelete = await authorService.DeleteAuthorAsync(id);
                if (authorToDelete == null)
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

