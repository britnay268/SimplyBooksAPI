using System;
using SimplyBooksAPI.Models;
namespace SimplyBooksAPI.Data;

public class BookData
{
    public static List<Books> Books = new List<Books>
    {
        new Books
        {
            Id = Guid.NewGuid(),
            Description = "",
            Image = "https://images-na.ssl-images-amazon.com/images/I/91+NBrXG-PL.jpg",
            Price = "24.99",
            Sale = false,
            Title = "A Promised Land",
            AuthorId = 2,
            UserId = 1
        },

        new Books
        {
            Id = Guid.NewGuid(),
            Description = "",
            Image = "https://images-na.ssl-images-amazon.com/images/I/A1agLFsWkOL.jpg",
            Price = "12.99",
            Sale = true,
            Title = "Children of Blood and Bone",
            AuthorId = 1,
            UserId = 1
        },

        new Books
        {
            Id = Guid.NewGuid(),
            Description = "",
            Image = "https://images-na.ssl-images-amazon.com/images/I/51529Lfc2ML.jpg",
            Price = "30.00",
            Sale = false,
            Title = "A People's History of the United States of America",
            AuthorId = 3,
            UserId = 1
        },

        new Books
        {
            Id = Guid.NewGuid(),
            Description = "",
            Image = "https://images-na.ssl-images-amazon.com/images/I/81rRRmZZvZL.jpg",
            Price = "15.89",
            Sale = false,
            Title = "Concrete Rose",
            AuthorId = 4,
            UserId = 1
        },

        new Books
        {
            Id = Guid.NewGuid(),
            Description = "",
            Image = "https://images-na.ssl-images-amazon.com/images/I/A1Cu4ywUeyL.jpg",
            Price = "25.00",
            Sale = true,
            Title = "The Underground Railroad",
            AuthorId = 5,
            UserId = 1
        },

        new Books
        {
            Id = Guid.NewGuid(),
            Description = "",
            Image = "https://res.cloudinary.com/bloomsbury-atlas/image/upload/w_360,c_scale/jackets/9781526622402.jpg",
            Price = "12.99",
            Sale = true,
            Title = "Hood Feminism",
            AuthorId = 6,
            UserId = 1
        },

        new Books
        {
            Id = Guid.NewGuid(),
            Description = "",
            Image = "https://images-na.ssl-images-amazon.com/images/I/81Uf1dTjfQL.jpg",
            Price = "15.00",
            Sale = false,
            Title = "A Blade So Black",
            AuthorId = 7,
            UserId = 1
        },

        new Books
        {
            Id = Guid.NewGuid(),
            Description = "",
            Image = "https://m.media-amazon.com/images/I/51BZdlchEsL.jpg",
            Price = "14.99",
            Sale = false,
            Title = "A Dream So Dark",
            AuthorId = 7,
            UserId = 1
        },

        new Books
        {
            Id = Guid.NewGuid(),
            Description = "",
            Image = "https://images-na.ssl-images-amazon.com/images/I/61GSqXVhhKL.jpg",
            Price = "12.00",
            Sale = false,
            Title = "The Fire Next Time",
            AuthorId = 8,
            UserId = 1
        },
    };
}

