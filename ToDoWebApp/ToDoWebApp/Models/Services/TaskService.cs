using System;
using System.Collections.Generic;
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

        public Task CreateATaskAsync(ToDoList task)
        {
            throw new NotImplementedException();
        }

        public Task DeleteTaskAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ToDoList> GetTaskByIDAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<ToDoList>> GetTasksAsync()
        {
            throw new NotImplementedException();
        }

        public Task UpdateTaskAsync(ToDoList task)
        {
            throw new NotImplementedException();
        }
    }
}