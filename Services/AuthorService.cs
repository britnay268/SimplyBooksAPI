using SimplyBooksAPI.Interfaces;
using SimplyBooksAPI.Models;

namespace SimplyBooksAPI.Services
{
	public class AuthorService : IAuthorService
	{
        private readonly IAuthorRepository _authorRepo;

        public AuthorService(IAuthorRepository authorRepo)
        {
            _authorRepo = authorRepo;
        }

        public async Task<List<Authors>> GetAuthorsAsync()
        {
            return await _authorRepo.GetAuthorsAsync();
        }

        public async Task<List<Authors>> GetUserAuthorsAsync(int userId)
        {
            return await _authorRepo.GetUserAuthorsAsync(userId);
        }

        public async Task<Authors> GetAuthorByIdAsync(int id)
        {
            return await _authorRepo.GetAuthorByIdAsync(id);
        }

        public async Task<List<Authors>> GetFavoriteAuthorsAsync()
        {
            return await _authorRepo.GetFavoriteAuthorsAsync();
        }

        public async Task<Authors> CreateAuthorAsync(Authors author)
        {
            return await _authorRepo.CreateAuthorAsync(author);
        }

        public async Task<Authors> UpdateAuthorAsync(int id, Authors author)
        {
            return await _authorRepo.UpdateAuthorAsync(id, author);
        }

        public async Task<Authors> DeleteAuthorAsync(int id)
        {
            return await _authorRepo.DeleteAuthorAsync(id);
        }
    }
}

