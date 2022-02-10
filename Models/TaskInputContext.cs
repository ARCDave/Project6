using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project6.Models
{
    public class TaskInputContext : DbContext
    {
        public TaskInputContext(DbContextOptions<TaskInputContext> options) : base(options)
        {
            // leave blank? I don't know what this does.
        }

        public DbSet<TaskInputModel> Responses { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Quadrant> Quadrants { get; set; }

        // Seed the data
        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<Category>().HasData(
                new Category { CategoryId = 1, CategoryName="Home"},
                new Category { CategoryId = 2, CategoryName = "School" },
                new Category { CategoryId = 3, CategoryName = "Work" },
                new Category { CategoryId = 4, CategoryName = "Church" }
            );

            mb.Entity<Quadrant>().HasData(
                new Quadrant { QuadrantId = 1, QuadrantName = "1 - Import/Urgent"},
                new Quadrant { QuadrantId = 2, QuadrantName = "2 - Important/Not Urgent" },
                new Quadrant { QuadrantId = 3, QuadrantName = "3 - Not Important/Urgent" },
                new Quadrant { QuadrantId = 4, QuadrantName = "4 - Not Important/Not Urgent" }
            );

            mb.Entity<TaskInputModel>().HasData(
                new TaskInputModel
                {
                    TaskId = 1,
                    DueDate = DateTime.Now,
                    QuadrantId = 1,
                    CategoryId = 2,
                    Completed = false
                }
            );
        }
    }
}
