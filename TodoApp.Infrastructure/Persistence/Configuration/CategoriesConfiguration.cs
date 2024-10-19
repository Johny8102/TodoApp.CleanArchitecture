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
    public class CategoriesConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.ToTable("Categories");
            builder.HasKey(option => option.Id);
            builder.Property(option => option.Name).IsRequired().HasMaxLength(50);
            builder.Property(option => option.IsActive).IsRequired();
            
        }
    }
}
