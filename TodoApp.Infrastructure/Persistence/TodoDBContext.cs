using Microsoft.EntityFrameworkCore;
using ToDoApp.Application.Common.Entities;
using ToDoApp.Infrastructure.Persistence.Configuration;



namespace ToDoApp.Infrastructure.Persistence
{
    public class TodoDBContext : DbContext
    {
        public TodoDBContext(DbContextOptions<TodoDBContext> dbContextOptions) : base(dbContextOptions) { }

        public DbSet<User> User { get; set; }
        public DbSet<TodoTask> TodoTasks { get; set; }
        public DbSet<Category> Category { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CategoriesConfiguration());
            modelBuilder.ApplyConfiguration(new UserConfiguration());
            modelBuilder.ApplyConfiguration(new TodoTaskConfiguration());


            base.OnModelCreating(modelBuilder);
        }






    }
}
