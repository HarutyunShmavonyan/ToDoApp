using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using ToDoApp.Common.Infrastructure;

namespace ToDoApp.Common.DAL.Abstract
{
    public interface IRepository<TEntity> where TEntity : Entity
    {
        Task<ICollection<TMapped>> GetAsync<TMapped>(Filter<TEntity> filter, Expression<Func<TEntity, TMapped>> projections);
        Task<ICollection<TEntity>> GetAsync(Filter<TEntity> filter);
        Task<TEntity> AddAsync(TEntity entity);
        Task<ICollection<TEntity>> AddManyAsync(ICollection<TEntity> entities);
        Task<TEntity> RemoveAsync(TEntity entity);
        Task<bool> RemoveAsync(long id);
    }
}
