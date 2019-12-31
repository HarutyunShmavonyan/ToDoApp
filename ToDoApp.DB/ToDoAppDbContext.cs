using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using ToDoApp.DB.Entities;
using ToDoApp.DB.ModelConfigurations;

namespace ToDoApp.DB
{
    public class ToDoAppDbContext : DbContext
    {
        public DbSet<ToDoRecord> ToDoRecords { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ToDoRecordConfiguration());
            modelBuilder.ApplyConfiguration(new UserConfiguration());

            base.OnModelCreating(modelBuilder);
        }

        protected ToDoAppDbContext()
        {
        }
    }
}
