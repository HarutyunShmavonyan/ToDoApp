using FluentValidation;
using ToDoApp.DB.Entities;

namespace ToDoApp.Common.DB.EntityValidationConfigurations
{
    public class UserValidatorConfiguration : AbstractValidator<User>
    {
        public UserValidatorConfiguration()
        {
            RuleFor(u => u.FirstName).MaximumLength(128);
            RuleFor(u => u.FirstName).NotNull();
        }
    }
}
