using System;
using SimplyBooksAPI.Models;
using SimplyBooksAPI.Data;

namespace SimplyBooksAPI.Endpoints
{
	public static class UserEndpoints
	{
        public static void MapUserEndpoints(this IEndpointRouteBuilder routes)
        {
            var group = routes.MapGroup("/api/users").WithTags(nameof(Users));

            group.MapGet("/", (SimplyBooksAPIDbContext db) =>
            {
                return db.Users;
            });
        }
	}
}

