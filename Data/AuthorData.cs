using System;
using SimplyBooksAPI.Models;

namespace SimplyBooksAPI.Data;

public class AuthorData
{
    public static List<Authors> Authors = new List<Authors>
    {
        new Authors
        {
            Id = 1,
            Email = "ta@ta.com",
            Favorite = true,
            FirstName = "Tomi",
            LastName = "Adeyemi",
            UserId = 1
        },
        new Authors
        {
            Id = 2,
            Email = "ba@obama.com",
            Favorite = true,
            FirstName = "Barack",
            LastName = "Obama",
            UserId = 1
        },
        new Authors
        {
            Id = 3,
            Email = "hz@zinn.com",
            Favorite = false,
            FirstName = "Howard",
            LastName = "Zinn",
            UserId = 1 
        },
        new Authors
        {
            Id = 4,
            Email = "at@thomas.com",
            Favorite = false,
            FirstName = "Angie",
            LastName = "Thomas",
            UserId = 1 
        },
        new Authors
        {
            Id = 5,
            Email = "cw@whithead.com",
            Favorite = false,
            FirstName = "Colson",
            LastName = "Whitehead",
            UserId = 1 
        },
        new Authors
        {
            Id = 6,
            Email = "mk@kendall.com",
            Favorite = true,
            FirstName = "Mikki",
            LastName = "Kendall",
            UserId = 1
        },
        new Authors
        {
            Id = 7,
            Email = "lm@lm.com",
            Favorite = true,
            FirstName = "L.L",
            LastName = "McKinney",
            UserId = 1
        },
        new Authors
        {
            Id = 8,
            Email = "jb@baldwin.com",
            Favorite = false,
            FirstName = "James",
            LastName = "Baldwin",
            UserId = 1 
        }
    };
}

