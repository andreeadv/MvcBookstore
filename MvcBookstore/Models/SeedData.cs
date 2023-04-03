using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcBookstore.Data;
using System;
using System.Linq;

namespace MvcBookstore.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new MvcBookstoreContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<MvcBookstoreContext>>()))
        {
            // Look for any movies.
            if (context.Book.Any())
            {
                return;   // DB has been seeded
            }
            context.Book.AddRange(
                new Book
                {
                    Title = "Me Before You",
                    Author ="Jojo Moyes",
                    ReleaseDate = DateTime.Parse("2012-1-5"),
                    Genre = "Romance",
                    Price = 20.99M
                },
                new Book
                {
                    Title = "Atomic Habits",
                    Author = "James Clear",
                    ReleaseDate = DateTime.Parse("2022-10-12"),
                    Genre = "Self Development",
                    Price = 11.99M
                },
                new Book
                {
                    Title = "Jane Eyre",
                    Author = "Charlotte Bronte",
                    ReleaseDate = DateTime.Parse("1847-2-12"),
                    Genre = "Buildungsroman",
                    Price = 8.99M
                },
                new Book
                {
                    Title = "Enigma Otiliei",
                    Author = "George Calinescu",
                    ReleaseDate = DateTime.Parse("1938-12-21"),
                    Genre = "Buildungsroman",
                    Price = 5.99M
                }
            );
            context.SaveChanges();
        }
    }
}