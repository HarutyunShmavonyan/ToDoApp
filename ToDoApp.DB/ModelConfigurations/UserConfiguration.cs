using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ToDoApp.Common.DB.Entities;

namespace ToDoApp.DB.ModelConfigurations
{
    public class UserConfiguration : IEntityTypeConfiguration<ToDoRecord>
    {
        public void Configure(EntityTypeBuilder<ToDoRecord> builder)
        {
            builder.Property(t => t.DueTo).HasColumnType("Date");
            builder.Property(t => t.Title).HasMaxLength(128).IsRequired();
        }
    }
}