using Microsoft.EntityFrameworkCore;
using StudentAdmin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentAdmin.Data
{
    public class StudentAdminContext : DbContext
    {
        public StudentAdminContext(DbContextOptions<StudentAdminContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Subject>().HasData(
                new Subject
                {
                    Id = 1,
                    Name = "HTML-CSS",
                    Description = "Khó 1"
                },
                 new Subject
                 {
                     Id = 2,
                     Name = "C#",
                     Description = "Khó 2"
                 },
                 new Subject
                 {
                     Id = 3,
                     Name = "PHP-Laravel",
                     Description = "Khó 3"
                 },
                 new Subject
                 {
                     Id = 4,
                     Name = "Java",
                     Description = "Khó 4"
                 },
                 new Subject
                 {
                     Id = 5,
                     Name = "ASP.NET",
                     Description = "Khó 5"
                 }
            );
        }

        public DbSet<Student> Student { get; set; }
        public DbSet<Mark> Mark { get; set; }
        public DbSet<Subject> Subject { get; set; }
    }
}
