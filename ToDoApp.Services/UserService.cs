using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using ToDoApp.Common.DAL.Abstract;
using ToDoApp.Common.SL.Abstract;
using ToDoApp.DB.Entities;

[assembly: InternalsVisibleTo("ToDoApp.WebApi")]
namespace ToDoApp.Services
{
    internal class UserService : IUserService
    {
        private readonly IUserRepository _repository;
        private readonly IUnitOfWork _unitOfWork;

        public UserService(IUserRepository repository, IUnitOfWork unitOfWork)
        {
            _repository = repository;
            _unitOfWork = unitOfWork;
        }

        public async Task<User> AddUserAsync(User user)
        {
            await _unitOfWork.BeginTransactionAsync();
            await _repository.AddAsync(user);
            _unitOfWork.Commit();

            return user;
        }
    }
}
