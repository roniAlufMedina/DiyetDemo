using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiyetDemo.DAL.Concrete.Context.Configurations
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.Property("ID").UseIdentityColumn();
            builder.Property("CategoryName").IsRequired().HasMaxLength(80).HasColumnType("nvarchar(80)");

            builder.HasMany(c => c.Foods).WithOne(f => f.Category);
            builder.HasKey("ID");
            builder.HasIndex(c=>c.CategoryName).IsUnique();

        }
    }
}
