using SimplyBooksAPI.Data;
using SimplyBooksAPI.Interfaces;
using SimplyBooksAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace SimplyBooksAPI.Repositories
{
	public class AuthorRepository : IAuthorRepository
	{
        private readonly SimplyBooksAPIDbContext dbContext;

        // Get All Authors
        public AuthorRepository(SimplyBooksAPIDbContext context)
        {
            dbContext = context;
        }

        public async Task<List<Authors>> GetAuthorsAsync()
        {
            return await dbContext.Authors.ToListAsync();
        }

        // Get User's Authors
        public async Task<List<Authors>> GetUserAuthorsAsync(int userId)
        {
            return await dbContext.Authors.Where(a => a.UserId == userId).ToListAsync();
        }

        // Get Author by Id (Get Author Books)
        public async Task<Authors> GetAuthorByIdAsync(int id)
        {
            return await dbContext.Authors.Include(b => b.AuthorBooks).FirstOrDefaultAsync(a => a.Id == id);
        }

        // Get Favorite Authors
        public async Task<List<Authors>> GetFavoriteAuthorsAsync()
        {
            return await dbContext.Authors.Where(a => a.Favorite == true).ToListAsync();
        }

        // Create Author
        public async Task<Authors> CreateAuthorAsync(Authors author)
        {
            dbContext.Authors.Add(author);
            await dbContext.SaveChangesAsync();
            return author;
        }

        // Update Author
        public async Task<Authors> UpdateAuthorAsync(int id, Authors author)
        {
            var existingAuthor = await dbContext.Authors.FindAsync(id);
            if (existingAuthor == null)
            {
                return null;
            }
            existingAuthor.Email = author.Email ?? existingAuthor.Email;
            existingAuthor.Favorite = author.Favorite != null ? author.Favorite : existingAuthor.Favorite;
            existingAuthor.FirstName = author.FirstName ?? existingAuthor.FirstName;
            existingAuthor.LastName = author.LastName ?? existingAuthor.LastName;

            await dbContext.SaveChangesAsync();
            return author;
        }

        // Delete Single Author and Books
        public async Task<Authors> DeleteAuthorAsync(int id)
        {
            var authorToDelete = await dbContext.Authors.Include(b => b.AuthorBooks).FirstOrDefaultAsync(a => a.Id == id);
            if (authorToDelete == null)
            {
                return null;
            }
            dbContext.Authors.Remove(authorToDelete);
            await dbContext.SaveChangesAsync();
            return authorToDelete;
        }
    }
}

