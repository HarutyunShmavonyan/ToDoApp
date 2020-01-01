using System.Threading.Tasks;
using ToDoApp.DB.Entities;

namespace ToDoApp.Common.SL.Abstract
{
    public interface IUserService
    {
        Task<User> AddUserAsync(User user);
    }
}