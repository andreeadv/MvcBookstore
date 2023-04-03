using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcBookstore.Data;
using System;
using System.Linq;

namespace MvcBookstore.Models;

public static class SeedData3
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new MvcBookstoreContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<MvcBookstoreContext>>()))
        {
            // Look for any publishers.
            if (context.Publisher.Any())
            {
                return;   // DB has been seeded
            }
            context.Publisher.AddRange(
                new Publisher
                {
                    Name = "BookZone",
                    City = "Bucharest",
                    Street = "Cartilor",
                    Phone = "0725458582",
                    Email= "bzone@gmail.com"

                },
                 new Publisher
                 {
                     Name = "Arthur",
                     City = "Bucharest",
                     Street = "Independentei",
                     Phone = "0712345678",
                     Email = "arthur@gmail.com"

                 },
                 new Publisher
                 {
                     Name = "Humanitas",
                     City = "Bucharest",
                     Street = "Florilor",
                     Phone = "0796385214",
                     Email = "humanitas@gmail.com"

                 },
                new Publisher
                {
                    Name = "Libris",
                    City = "Brasov",
                    Street = "Zaharia",
                    Phone = "0728465792",
                    Email = "librisbooks@gmail.com"

                }
            );
            context.SaveChanges();
        }
    }
}