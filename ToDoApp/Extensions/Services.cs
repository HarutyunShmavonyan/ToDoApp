using System;
using Autofac;
using Autofac.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;
using ToDoApp.Common.SL.Abstract;
using ToDoApp.Services;
using ToDoApp.Services.ValidationProxies;

namespace ToDoApp.WebApi.Extensions
{
    public static class Services
    {
        public static IServiceProvider AddServices(this IServiceCollection services)
        {
            services.AddOptions();
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<IUserService, UserService>();

            var builder = new ContainerBuilder();
            builder.Populate(services);

            builder.RegisterDecorator<UserServiceValidationProxy, IUserService>();
            var container = builder.Build();

            return new AutofacServiceProvider(container);
        }
    }
}
