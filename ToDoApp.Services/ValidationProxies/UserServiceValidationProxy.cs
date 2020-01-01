using System.Threading.Tasks;
using FluentValidation.Results;
using ToDoApp.Common.Abstract;
using ToDoApp.Common.DB.Entities;
using ToDoApp.Common.SL.Abstract;

namespace ToDoApp.Services.ValidationProxies
{
    public class UserServiceValidationProxy : ServiceValidationBase<User>, IUserService
    {
        private readonly IUserService _userService;

        public UserServiceValidationProxy(IUserService userService, IValidator<User, ValidationResult> validator) : base(validator)
        {
            _userService = userService;
        }

        public Task<User> AddUserAsync(User user)
        {
            Validate(user);
            return _userService.AddUserAsync(user);
        }
    }
}
