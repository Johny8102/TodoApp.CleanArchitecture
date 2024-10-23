using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoApp.Presentation.Common.Entities
{
    public class CategoryPresentation
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; } = true;
        public List<TodoTaskPresentation> tasks { get; set; }
    }
}
