using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CoursesMVCTypre.Models;

namespace CoursesMVCTypre.Data
{
    public class CoursesMVCTypreContext : DbContext
    {
        public CoursesMVCTypreContext (DbContextOptions<CoursesMVCTypreContext> options)
            : base(options)
        {
        }

        public DbSet<CoursesMVCTypre.Models.Subjects> Subjects { get; set; } = default!;
    }
}
