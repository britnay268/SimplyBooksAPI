using System;
using SimplyBooksAPI.Interfaces;
using SimplyBooksAPI.Models;

namespace SimplyBooksAPI.Services
{
	public class BookService : IBookService
	{
		private readonly IBookRepository _bookRepo;

        public BookService(IBookRepository bookRepo)
        {
            _bookRepo = bookRepo;
        }

        public async Task<List<Books>> GetBooksAsync()
        {
            return await _bookRepo.GetBooksAsync();
        }

        public async Task<List<Books>> GetUserBooksAsync(int userId)
        {
            return await _bookRepo.GetUserBooksAsync(userId);
        }

        public async Task<Books> GetBooksByIdAsync(Guid id)
        {
            return await _bookRepo.GetBooksByIdAsync(id);
        }

        public async Task<Books> CreateBookAsync(Books book)
        {
            return await _bookRepo.CreateBookAsync(book);
        }

        public async Task<Books> UpdateBookAsync(Guid id, Books book)
        {
            return await _bookRepo.UpdateBookAsync(id, book);
        }

        public async Task<Books> DeleteBookAsync(Guid id)
        {
            return await _bookRepo.DeleteBookAsync(id);
        }
    }
}

