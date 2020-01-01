using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using ToDoApp.Common.Abstract;
using ToDoApp.Common.DB.Entities;
using ToDoApp.Common.DB.EntityValidationConfigurations;
using ToDoApp.Common.Infrastructure;

namespace ToDoApp.WebApi.Extensions
{
    public static class ValidationConfigurations
    {
        public static void AddValidationConfigurations(this IServiceCollection services)
        {
            services.AddScoped<AbstractValidator<User>, UserValidatorConfiguration>();
            services.AddScoped(typeof(IValidator<,>), typeof(Validator<>));
        }
    }
}
