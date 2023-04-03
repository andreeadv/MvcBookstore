using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcBookstore.Data;
using System;
using System.Linq;

namespace MvcBookstore.Models;

public static class SeedData4
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new MvcBookstoreContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<MvcBookstoreContext>>()))
        {
            // Look for any sections.
            if (context.Section.Any())
            {
                return;   // DB has been seeded
            }
            context.Section.AddRange(
                new Section
                {
                    Domain = "Romance",
                    Hall = 1
                },
                 new Section
                 {
                     Domain = "History",
                     Hall = 1
                 },
                 new Section
                 {
                     Domain = "Contemporary",
                     Hall = 2
                 },
                new Section
                {
                    Domain = "Poetry",
                    Hall = 2
                }
            );
            context.SaveChanges();
        }
    }
}