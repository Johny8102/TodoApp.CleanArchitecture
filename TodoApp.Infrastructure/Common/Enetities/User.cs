﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoApp.Infrastructure.Common.Enetities
{
    public class User
    {
        public int Id { get; set; }
        public int parentId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public List<TodoTask> Tasks { get; set; }

    }
}
