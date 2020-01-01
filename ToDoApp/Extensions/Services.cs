using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using ToDoApp.Common.DAL.Abstract;
using ToDoApp.Common.SL.Abstract;
using ToDoApp.DAL;
using ToDoApp.DB.Entities;
using ToDoApp.Services;

namespace ToDoApp.WebApi.Extensions
{
    public static class Services
    {
        public static void AddServices(this IServiceCollection services)
        {
            services.AddScoped<IUnitOfWork, UnitOfWork>();

            services.AddScoped<IUserService, UserService>();
        }
    }
}
