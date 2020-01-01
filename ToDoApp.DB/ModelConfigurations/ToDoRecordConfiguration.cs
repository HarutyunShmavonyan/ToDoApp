using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ToDoApp.Common.DB.Entities;

namespace ToDoApp.DB.ModelConfigurations
{
    public class ToDoRecordConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.Property(t => t.Email).HasMaxLength(256).IsRequired();
            builder.Property(t => t.FirstName).HasMaxLength(256).IsRequired();
            builder.Property(t => t.SecondName).HasMaxLength(256).IsRequired();
        }
    }
}