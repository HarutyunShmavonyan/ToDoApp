using System;
using System.Collections.Generic;
using System.Text;
using ToDoApp.Common.DAL.Abstract;
using ToDoApp.DB;
using ToDoApp.DB.Entities;

namespace ToDoApp.DAL
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        public UserRepository(ToDoAppDbContext context) : base(context)
        {
        }
    }
}
