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
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            ConfigurUserTable(builder);
        }

        private void ConfigurUserTable(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("Users");
            builder.HasKey(option => option.Id);
            builder.Property(option => option.Name).IsRequired().HasMaxLength(50);
            builder.Property(option => option.Email).IsRequired().HasMaxLength(100);
            builder.Property(option => option.Password).IsRequired().HasMaxLength(50);
            builder.HasIndex(option => option.Email).IsUnique();
            


           

            
            //parentId is a foreign key for Task

        }


    }
}
