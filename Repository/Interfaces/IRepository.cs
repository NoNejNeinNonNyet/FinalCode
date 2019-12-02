using Entities.DbEntities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Repository.Interfaces
{
    public interface IRepository<T> where T : BaseEntity
    {
        bool Add(T entity);
        void Edit(T entity);
        void Delete(T entity);
        IEnumerable<T> All();
        IEnumerable<T> All(Expression<Func<T, bool>> predicate);
        void SaveChanges();
    }
}
