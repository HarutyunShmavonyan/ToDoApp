using ToDoApp.Common.DAL.Abstract;
using ToDoApp.Common.DB.Entities;
using ToDoApp.DB;

namespace ToDoApp.DAL
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        public UserRepository(ToDoAppDbContext context) : base(context)
        {
        }
    }
}
