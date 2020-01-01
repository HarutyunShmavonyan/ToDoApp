using Microsoft.EntityFrameworkCore;
using ToDoApp.Common.DB.Entities;
using ToDoApp.DB.ModelConfigurations;

namespace ToDoApp.DB
{
    public class ToDoAppDbContext : DbContext
    {
        public DbSet<ToDoRecord> ToDoRecords { get; set; }
        public DbSet<User> Users { get; set; }

        public ToDoAppDbContext(DbContextOptions<ToDoAppDbContext> options) : base(options)
        {
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ToDoRecordConfiguration());
            modelBuilder.ApplyConfiguration(new UserConfiguration());

            base.OnModelCreating(modelBuilder);
        }

    }
}
