using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ToDoApp.Common.DAL.Abstract;
using ToDoApp.Common.Infrastructure;
using ToDoApp.DB;

namespace ToDoApp.DAL
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : Entity, new()
    {
        private readonly ToDoAppDbContext _context;

        public Repository(ToDoAppDbContext context)
        {
            _context = context;
        }

        public async Task<ICollection<TMapped>> GetAsync<TMapped>(Filter<TEntity> filter, Expression<Func<TEntity, TMapped>> projections)
        {
            var query = _context.Set<TEntity>().AsNoTracking();
            query = ApplyFilter(query, filter);

            return await query.Select(projections).ToListAsync();
        }

        public async Task<ICollection<TEntity>> GetAsync(Filter<TEntity> filter)
        {
            var query = _context.Set<TEntity>().AsNoTracking();
            query = ApplyFilter(query, filter);
            
            return await query.ToListAsync();
        }

        public async Task<TEntity> AddAsync(TEntity entity)
        {
            _context.Add(entity);
            await _context.SaveChangesAsync();

            return entity;
        }

        public async Task<ICollection<TEntity>> AddManyAsync(ICollection<TEntity> entities)
        {
            foreach (var entity in entities)
            {
                _context.Add(entity);
            }
            await _context.SaveChangesAsync();

            return entities;
        }

        public async Task<TEntity> RemoveAsync(TEntity entity)
        {
            _context.Remove(entity);
            await _context.SaveChangesAsync();

            return entity;
        }

        public async Task<bool> RemoveAsync(long id)
        {
            _context.Remove(new TEntity { Id = id });
            var removedCount = await _context.SaveChangesAsync();

            return removedCount != 0;
        }

        private IQueryable<TEntity> ApplyFilter(IQueryable<TEntity> query, Filter<TEntity> filter)
        {
            foreach (var includedProperty in filter.IncludedProperties)
            {
                query = query.Include(includedProperty);
            }

            foreach (var condition in filter.Conditions)
            {
                query = query.Where(condition);
            }

            return query;
        }
    }
}
