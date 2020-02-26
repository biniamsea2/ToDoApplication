using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using ToDoWebApp.Data;
using ToDoWebApp.Models.Interfaces;

namespace ToDoWebApp.Models.Services
{
    public class TaskService : ITaskManager
    {
        private StorageDbContext _context;

        public TaskService(StorageDbContext context)
        {
            _context = context;
        }

        public async Task CreateATaskAsync(ToDoList task)
        {
            await _context.AddAsync(task);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteTaskAsync(int id)
        {
            ToDoList task = await GetTaskByIDAsync(id);
            _context.ToDoPackage.Remove(task);
            await _context.SaveChangesAsync();
        }

        public async Task<ToDoList> GetTaskByIDAsync(int id) => await _context.ToDoPackage.FirstOrDefaultAsync(t1 => t1.ID == id);

        public async Task<List<ToDoList>> GetTasksAsync()
        {
            List<ToDoList> tasks = await _context.ToDoPackage.ToListAsync();
            return tasks;
        }

        public async Task UpdateTaskAsync(ToDoList task)
        {
            _context.Update(task);
            await _context.SaveChangesAsync();
        }
    }
}