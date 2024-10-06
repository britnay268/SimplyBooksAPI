using SimplyBooksAPI.Models;

namespace SimplyBooksAPI.Interfaces
{
	public interface IAuthorRepository
	{
        // Get All Authors
        Task<List<Authors>> GetAuthorsAsync();

        // Get User's Authors
        Task<List<Authors>> GetUserAuthorsAsync(int userId);

        // Get Author by Id (Get Author Books)
        Task<Authors> GetAuthorByIdAsync(int id);

        // Get Favorite Authors
        Task<List<Authors>> GetFavoriteAuthorsAsync();

        // Create Author
        Task<Authors> CreateAuthorAsync(Authors author);

        // Update Author
        Task<Authors> UpdateAuthorAsync(int id, Authors author);

        // Delete Single Author and Books
        Task<Authors> DeleteAuthorAsync(int id);
    }
}

