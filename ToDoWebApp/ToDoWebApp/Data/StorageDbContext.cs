using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToDoWebApp.Models;

namespace ToDoWebApp.Data
{
    public class StorageDbContext : DbContext
    {
        public StorageDbContext(DbContextOptions<StorageDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ToDoList>().HasData(
                new ToDoList
                {
                    ID = 1,
                    Task = "Do Homework",
                    Priority = Priority.Low,
                    Completed = false,
                    DueDate = "2/20/2020"
                },
                new ToDoList
                {
                    ID = 2,
                    Task = "Get an oil change",
                    Priority = Priority.High,
                    Completed = false,
                    DueDate = "2/26/2020"
                },
                new ToDoList
                {
                    ID = 3,
                    Task = "Clean room",
                    Priority = Priority.Medium,
                    Completed = true,
                    DueDate = "2/24/2020"
                },
                new ToDoList
                {
                    ID = 4,
                    Task = "Go to the gym",
                    Priority = Priority.High,
                    Completed = true,
                    DueDate = "2/23/2020"
                },
                new ToDoList
                {
                    ID = 5,
                    Task = "Wash dishes",
                    Priority = Priority.Low,
                    Completed = false,
                    DueDate = "2/22/2020"
                }) ;
        }

        public DbSet<ToDoList> ToDoPackage { get; set; }
    }
}
