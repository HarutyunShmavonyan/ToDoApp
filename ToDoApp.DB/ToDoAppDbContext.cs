using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoApp.DB
{
    public class ToDoAppDbContext : DbContext
    {
        protected ToDoAppDbContext()
        {
        }
    }
}
