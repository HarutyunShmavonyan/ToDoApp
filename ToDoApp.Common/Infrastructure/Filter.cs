using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace ToDoApp.Common.Infrastructure
{
    public class Filter<TEntity>
    {
        public ICollection<Expression<Func<TEntity, bool>>> Conditions { get; } = new List<Expression<Func<TEntity, bool>>>();
        public ICollection<Expression<Func<TEntity, object>>> IncludedProperties { get; } = new List<Expression<Func<TEntity, object>>>();

        public Filter<TEntity> Condition(Expression<Func<TEntity, bool>> condition)
        {
            Conditions.Add(condition);
            return this;
        }

        public Filter<TEntity> Include(Expression<Func<TEntity, object>> property)
        {
            IncludedProperties.Add(property);
            return this;
        }
    }
}