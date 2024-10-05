using System;
using Microsoft.EntityFrameworkCore;
using SimplyBooksAPI.Models;
namespace SimplyBooksAPI.Data;

public class SimplyBooksAPIDbContext : DbContext
{
	public DbSet<Authors> Authors { get; set; }
    public DbSet<Books> Books { get; set; }
    public DbSet<Users> Users { get; set; }
    public DbSet<AuthorBooks> AuthorBooks { get; set; }

    public SimplyBooksAPIDbContext(DbContextOptions<SimplyBooksAPIDbContext> context) : base(context)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Authors>().HasData(AuthorData.Authors);
        modelBuilder.Entity<Books>().HasData(BookData.Books);
        modelBuilder.Entity<Users>().HasData(UserData.Users);
        modelBuilder.Entity<AuthorBooks>()
        .HasKey(ab => new { ab.AuthorId, ab.BookId });
        modelBuilder.Entity<AuthorBooks>()
            .HasOne(ab => ab.Book)
            .WithMany(b => b.AuthorBooks)
            .HasForeignKey(ab => ab.BookId);
        modelBuilder.Entity<AuthorBooks>()
            .HasOne(ab => ab.Author)
            .WithMany(a => a.AuthorBooks)
            .HasForeignKey(ab => ab.AuthorId);
    }
}

