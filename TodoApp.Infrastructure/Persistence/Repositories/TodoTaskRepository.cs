using ToDoApp.Application.Common.Entities;
using ToDoApp.Application.Common.Interfaces.Persistence;


namespace ToDoApp.Infrastructure.Persistence.Repositories
{
    public class TodoTaskRepository : ITodoTaskRepository
    {
        TodoDBContext _todoDBContext;

        public TodoTaskRepository(TodoDBContext todoDBContext)
        {
            _todoDBContext = todoDBContext;
        }


        public void AddTask(TodoTask task)
        {
            _todoDBContext.TodoTasks.Add(task);
            _todoDBContext.SaveChanges();
        }

        public void DeleteTask(int taskId)
        {
            _todoDBContext.TodoTasks.Remove(GetTask(taskId));
            _todoDBContext.SaveChanges();
        }

        public List<TodoTask> GetTasks()
        {
            return _todoDBContext.TodoTasks.ToList();
        }

        public void updateTask(TodoTask task)
        {
            _todoDBContext.TodoTasks.Update(task);
            _todoDBContext.SaveChanges();
        }

        public TodoTask GetTask(int taskId) { return _todoDBContext.TodoTasks.Find(taskId); }


    }
}
