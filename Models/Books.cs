using System;
namespace SimplyBooksAPI.Models
{
	public class Books
	{
        public int Id { get; set; }
        public string? Description { get; set; }
        public string Image { get; set; }
        public string Price { get; set; }
        public string Title { get; set; }
        public bool Sale { get; set; }
        public int AuthorId { get; set; }
        public Authors Author { get; set; }
        public int UserId { get; set; }
        public Users User { get; set; }
        public List<AuthorBooks> AuthorBooks { get; set; }
    }
}
