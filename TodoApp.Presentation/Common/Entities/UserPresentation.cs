using ToDoApp.Presentation.Common.Entities;

namespace TodoApp.Presentation.Common.Entities
{
    public class UserPresentation
    {
        public int Id { get; set; }
        public int ParentId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public List<TodoTaskPresentation> Tasks { get; set; }
    }
}
