using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoApp.Domain.Aggregate.CategoriesAggregate;
using ToDoApp.Domain.Aggregate.UserAggregate;

namespace ToDoApp.Domain.Aggregate.TaskAggregate
{
    public class TodoTask
    {
        public int Id { get; private set; }
        public string Description { get; private set; }
        public string Title { get; private set; }
        public DateTime CreatedTime { get; private set; }
        public bool IsChecked { get; private set; }
        public DateOnly DeadLine { get; private set; }

        public int? ParentId { get; set; }
        public TodoTask ParentTodoTask { get; set; }

        //entity
        public List<TodoTask> SubTasks { get; private set; }
        public List<User> Users { get; private set; }
        public List<Categories> Categories { get; private set; }
        public TodoTask(int id, string description, string title, DateTime createdtime, bool ischecked, DateOnly deadline, List<TodoTask> subtasks)
        {
            Id = id;
            Description = description;
            Title = title;
            CreatedTime = createdtime;
            IsChecked = ischecked;
            SubTasks = subtasks;
            DeadLine = deadline;
        }


    }
}
