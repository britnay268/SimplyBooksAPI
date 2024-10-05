using System;
namespace SimplyBooksAPI.Models
{
	public class AuthorBooks
	{
        public int AuthorId { get; set; }
        public Authors Author { get; set; }

        public int BookId { get; set; }
        public Books Book { get; set; }

        public int UserId { get; set; }
        public Users User { get; set; }
    }
}

