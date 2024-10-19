

using ToDoApp.Domain.Aggregate.TaskAggregate;

namespace ToDoApp.Domain.Aggregate.CategoriesAggregate
{
    public class Categories
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public bool IsActive { get; private set; } = true;
        public List<TodoTask> tasks { get; private set; }
        


        public Categories(int id, string name, bool isActive, List<TodoTask> tasks  )
        {
            Id = id;
            Name = name;
            IsActive = isActive;
            this.tasks = tasks;
        }
    }
}
