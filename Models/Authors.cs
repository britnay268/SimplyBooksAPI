using System;
namespace SimplyBooksAPI.Models
{
	public class Authors
	{
        public int Id { get; set; }
        public string Email { get; set; }
        public bool Favorite { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int UserId { get; set; }
        public Users User { get; set; }
        public List<AuthorBooks> AuthorBooks { get; set; }
    }
}

