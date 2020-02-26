using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ToDoWebApp.Models
{
    public class ToDoList
    {
        public int ID { get; set; }
        [Required]
        public string Task { get; set; }
        [Required]
        public Priority Priority  { get; set; }
        [Required]
        public bool Completed { get; set; }
        [Required]
        [Display(Name = "Due Date")]
        public string DueDate { get; set; }

    }

    public enum Priority
    {
        Low,
        Medium,
        High
    }
}
