using Entities.DbEntities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Services.Interfaces
{
    public interface IService<T> where T : BaseEntity
    {
        void Create(T entity);
        void Create(List<T> entities);
        void Update(T entity);
        void Delete(T entity);
        IEnumerable<T> GetAll();
        IEnumerable<T> GetAll(Expression<Func<T, bool>> predicate);
    }
}
