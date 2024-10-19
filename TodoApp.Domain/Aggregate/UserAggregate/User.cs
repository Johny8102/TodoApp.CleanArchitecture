using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ToDoApp.Domain.Aggregate.TaskAggregate;


namespace ToDoApp.Domain.Aggregate.UserAggregate
{
    public class User
    {
        public int Id { get; private set; }
        public int ParentId { get; private set; }
        public string Name { get; private set; }
        public string Email { get; private set; }
        public string Password { get; private set; }
        public List<TodoTask> Tasks { get; private set; }


        public User(int Id ,  string Name, string Email, string Password , List<TodoTask> tasks , int parentId)
        {
            this.Id = Id;
            this.Name = Name;
            this.Email = Email; 
            this.Password = Password;
            this.ParentId = parentId;
            this.Tasks = tasks;
        }


    }
}
