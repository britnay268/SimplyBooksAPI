using System;
using Microsoft.EntityFrameworkCore;
using SimplyBooksAPI.Data;
using SimplyBooksAPI.Interfaces;
using SimplyBooksAPI.Models;

namespace SimplyBooksAPI.Repositories
{
	public class BookRepository : IBookRepository
	{
		private readonly SimplyBooksAPIDbContext dbContext;

		public BookRepository(SimplyBooksAPIDbContext context)
		{
			dbContext = context;
		}

        // Get All Books
        public async Task<List<Books>> GetBooksAsync()
        {
            return await dbContext.Books.Include(b => b.User).Include(b => b.Author).ToListAsync();
        }

        // Get User's Books
        public async Task<List<Books>> GetUserBooksAsync(int userId)
        {
            return await dbContext.Books.Where(b => b.UserId == userId).Include(b => b.User).Include(b => b.Author).ToListAsync();
        }

        // Get Book by Id
        public async Task<Books> GetBooksByIdAsync(Guid id)
        {
            return await dbContext.Books.Include(b => b.User).Include(b => b.Author).FirstOrDefaultAsync(b => b.Id == id);
        }

        // Create Book
        public async Task<Books> CreateBookAsync(Books book)
        {
            dbContext.Books.Add(book);
            await dbContext.SaveChangesAsync();
            return book;
        }

        // Update Book
        public async Task<Books> UpdateBookAsync(Guid id, Books book)
        {
            var existingBook = await dbContext.Books.FindAsync(id);
            if (existingBook == null)
            {
                return null;
            }
            existingBook.Description = book.Description ?? existingBook.Description;
            existingBook.Image = book.Image ?? existingBook.Image;
            existingBook.Price = book.Price ?? existingBook.Price;
            existingBook.Title = book.Title ?? existingBook.Title;
            existingBook.Sale = book.Sale != null ? book.Sale : existingBook.Sale;
            existingBook.AuthorId = book.AuthorId != 0 ? book.AuthorId : existingBook.AuthorId;

            await dbContext.SaveChangesAsync();
            return book;
        }

        // Delete Book
        public async Task<Books> DeleteBookAsync(Guid id)
        {
            var bookToDelete = await dbContext.Books.FindAsync(id);
            if (bookToDelete == null)
            {
                return null;
            }
            dbContext.Books.Remove(bookToDelete);
            await dbContext.SaveChangesAsync();
            return bookToDelete;
        }
    }
}

