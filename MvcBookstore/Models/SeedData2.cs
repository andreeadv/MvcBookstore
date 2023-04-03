using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcBookstore.Data;
using System;
using System.Linq;

namespace MvcBookstore.Models;

public static class SeedData2
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new MvcBookstoreContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<MvcBookstoreContext>>()))
        {
            // Look for any readers.
            if (context.Reader.Any())
            {
                return;   // DB has been seeded
            }
            context.Reader.AddRange(
                new Reader
                {
                    Name = "Dina Mary",
                    City = "Bucharest",
                    BirthDate = DateTime.Parse("2000-1-5"),
                    email = "dmary@gmail.com",
                    
                },
                new Reader
                {
                    Name = "Jake Fin",
                    City = "Bucharest",
                    BirthDate = DateTime.Parse("2002-5-6"),
                    email = "jfin@gmail.com",
                },
                new Reader
                {
                    Name = "Jhon Kevin",
                    City = "Bucharest",
                    BirthDate = DateTime.Parse("2004-8-9"),
                    email = "jkevin@gmail.com",
                },
                new Reader
                {
                    Name = "Mary Anne",
                    City = "Bucharest",
                    BirthDate = DateTime.Parse("2003-2-2"),
                    email = "anne@gmai.com",
                }
            );
            context.SaveChanges();
        }
    }
}