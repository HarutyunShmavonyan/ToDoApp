using Microsoft.Extensions.DependencyInjection;
using ToDoApp.Common.DAL.Abstract;
using ToDoApp.Common.DB.Entities;
using ToDoApp.DAL;

namespace ToDoApp.WebApi.Extensions
{
    public static class Repositories
    {
        public static void AddRepositories(this IServiceCollection services)
        {
            services.AddScoped(typeof(IRepository<User>), typeof(Repository<User>));
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IToDoRecordRepository, ToDoRecordRepository>();
        }
    }
}
