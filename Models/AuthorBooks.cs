using System;
namespace SimplyBooksAPI.Models
{
	public class AuthorBooks
	{
        public int AuthorId { get; set; }
        public Authors Author { get; set; }

        public Guid BookId { get; set; }
        public Books Book { get; set; }
    }
}

