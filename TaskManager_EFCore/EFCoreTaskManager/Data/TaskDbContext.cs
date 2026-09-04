using EFCoreTaskManager.Models;
using Microsoft.EntityFrameworkCore;

namespace EFCoreTaskManager.Data
{
    public class TaskDbContext : DbContext
    {
        public TaskDbContext(DbContextOptions<TaskDbContext> options)
    : base(options) { }
        public DbSet<TaskItem> Tasks { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Seed Categories
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Work" },
                new Category { Id = 2, Name = "Personal" },
                new Category { Id = 3, Name = "Study" },
                new Category { Id = 4, Name = "Temporary" }
            );

            // Seed Tasks
            modelBuilder.Entity<TaskItem>().HasData(
                new TaskItem { Id = 1, Title = "Finish report", CategoryId = 1, Description = "Complete the monthly report", IsCompleted = false },
                new TaskItem { Id = 2, Title = "Buy groceries", CategoryId = 2, Description = "Get milk, eggs, and bread", IsCompleted = false },
                new TaskItem { Id = 3, Title = "Study ASP.NET", CategoryId = 3, Description = "Read about Razor Pages and MVC", IsCompleted = false }
            );
        }


    }
}
