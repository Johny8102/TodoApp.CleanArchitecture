using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoApp.Application.Common.Entities;

namespace ToDoApp.Infrastructure.Persistence.Configuration
{
    public class TodoTaskConfiguration : IEntityTypeConfiguration<TodoTask>
    {
        public void Configure(EntityTypeBuilder<TodoTask> builder)
        {
            builder.ToTable("TodoTasks");
            builder.HasKey(option => option.Id);
            builder.Property(option => option.Title).IsRequired().HasMaxLength(50);
            builder.Property(option => option.Description).IsRequired().HasMaxLength(350);
            builder.Property(option => option.CreatedTime).IsRequired();
            builder.Property(option => option.IsChecked).IsRequired();
            builder.Property(option => option.DeadLine).IsRequired();
            builder.Property(option => option.Title).IsRequired().HasMaxLength(50);

            builder.HasMany(option => option.Users).WithMany(option => option.Tasks).UsingEntity(option => option.ToTable("UsersAndTasks"));
            builder.HasMany(option => option.Categories).WithMany(option => option.tasks).UsingEntity(option => option.ToTable("CategoriesAndTasks"));
            builder.HasOne(option => option.ParentTodoTask).WithMany(option => option.SubTasks).HasForeignKey(option=>option.ParentId).OnDelete(DeleteBehavior.NoAction);



        }
    }
}
