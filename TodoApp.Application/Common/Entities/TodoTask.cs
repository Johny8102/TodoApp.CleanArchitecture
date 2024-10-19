using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoApp.Application.Common.Entities
{
    public class TodoTask
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string Title { get; set; }
        public DateTime CreatedTime { get; set; }
        public bool IsChecked { get; set; }
        public DateOnly DeadLine { get; set; }

        public int? ParentId { get; set; }
        public TodoTask ParentTodoTask { get; set; }

        public List<TodoTask> SubTasks { get; set; }
        public List<User> Users { get; set; }
        public List<Category> Categories { get; set; }
    }
}
