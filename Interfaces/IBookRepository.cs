using System;
using SimplyBooksAPI.Models;

namespace SimplyBooksAPI.Interfaces
{
	public interface IBookRepository
    {
		// Get All Books
		Task<List<Books>> GetBooksAsync();
		// Get User's Books
		Task<List<Books>> GetUserBooksAsync(int userId);
		// Get Book by Id
		Task<Books> GetBooksByIdAsync(Guid id);
        // Create Book
        Task<Books> CreateBookAsync(Books book);
        // Update Book
        Task<Books> UpdateBookAsync(Guid id, Books book);
        // Delete Book
        Task<Books> DeleteBookAsync(Guid id);
    }
}

