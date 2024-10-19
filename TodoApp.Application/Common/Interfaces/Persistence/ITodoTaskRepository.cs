using ToDoApp.Application.Common.Entities;

namespace ToDoApp.Application.Common.Interfaces.Persistence
{
    public interface ITodoTaskRepository
    {
        void AddTask(TodoTask task);
        void updateTask(TodoTask task);
        void DeleteTask(int taskId);
        List<TodoTask> GetTasks();
    }
}
