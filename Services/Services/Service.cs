using Entities.DbEntities;
using Repository.Interfaces;
using Repository.Repositories;
using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Services.Services
{
    public abstract class Service<T, R> : IService<T>
        where T : BaseEntity
        where R : IRepository<T>
    {
        public virtual R Repository { get; protected set; }

        public virtual void Create(T entity)
        {
            Repository.Add(entity);
            Repository.SaveChanges();
        }

        public virtual void Create(List<T> entities)
        {
            if (entities == null) return;
            foreach (var entity in entities)
            {
                Repository.Add(entity);
            }
            Repository.SaveChanges();
        }

        public virtual void Delete(T entity)
        {
            Repository.Delete(entity);
            Repository.SaveChanges();
        }

        public virtual IEnumerable<T> GetAll()
        {
            return Repository.All();
        }

        public virtual IEnumerable<T> GetAll(Expression<Func<T, bool>> predicate)
        {
            return Repository.All(predicate);
        }

        public virtual void Update(T entity)
        {
            Repository.Edit(entity);
            Repository.SaveChanges();
        }
    }
}
