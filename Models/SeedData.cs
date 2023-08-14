using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using CoursesMVCTypre.Data;
using System;
using System.Linq;
using CoursesMVCTypre.Models;

namespace MvcMovie.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new CoursesMVCTypreContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<CoursesMVCTypreContext>>()))
        {
          
            if (context.Subjects.Any())
            {
                return;   // DB has been seeded
            }
            context.Subjects.AddRange(
                new Subjects
                {
                    Title = "Kevin Haris",
                    JoinDate = DateTime.Parse("2020-2-12"),
                    Gender = "Male",
                    Rating = 7.9M
                },
                new Subjects
                {
                    Title = "Dharmin Patel",
                    JoinDate = DateTime.Parse("2021-3-13"),
                    Gender = "Male",
                    Rating = 9.00M
                },
                new Subjects
                {
                    Title = "Kevin Patel",
                    JoinDate = DateTime.Parse("2022-2-23"),
                    Gender = "Female",
                    Rating = 9.9M
                },
                new Subjects
                {
                    Title = "Zais Abbas",
                    JoinDate = DateTime.Parse("2021-4-15"),
                    Gender = "Male",
                    Rating = 3.99M
                }
            );
            context.SaveChanges();
        }
    }
}