using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoApp.Presentation.Common.Entities;

namespace ToDoApp.Presentation.Common.Entities
{
    public class TodoTaskPresentation
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string Title { get; set; }
        public DateTime CreatedTime { get; set; }
        public bool IsChecked { get; set; }
        public DateOnly DeadLine { get; set; }

        public int? ParentId { get; set; }
        public TodoTaskPresentation ParentTodoTask { get; set; }

        public List<TodoTaskPresentation> SubTasks { get; set; }
        public List<UserPresentation> Users { get; set; }
        public List<CategoryPresentation> Categories { get; set; }
    }
}
