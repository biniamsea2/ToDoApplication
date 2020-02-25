using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToDoWebApp.Models.Interfaces
{
    interface ITaskManager
    {
        //create a task
        Task CreateATaskAsync(ToDoList task);

        //Get individual Task
        Task<ToDoList> GetTaskByIDAsync(int id);

        //Get all tasks
        Task<List<ToDoList>> GetTasksAsync();

        //Update task
        Task UpdateTaskAsync(ToDoList task);

        //Delete task
        Task DeleteTaskAsync(int id);
    }
}
