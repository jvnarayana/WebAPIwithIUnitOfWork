using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using RestAPIProjectForRepositoryPattern.DBAccess;

namespace RestAPIProjectForRepositoryPattern.Models
{
    public class GenericRepository<T>: IGenericRepository<T> where T:class

    {
        private readonly AppilicationDBContext _appilicationDBContext;

        public GenericRepository(AppilicationDBContext appilicationDBContext)
        {
            _appilicationDBContext = appilicationDBContext;
        }

        public void Add(T entity)
        {
            _appilicationDBContext.Set<T>().Add(entity);
        }

        public void AddRange(IEnumerable<T> entities)
        {
            _appilicationDBContext.Set<T>().AddRange(entities);
        }

        public IEnumerable<T> Find(Expression<Func<T, bool>> expression)
        {
           return  _appilicationDBContext.Set<T>().Where(expression);
        }

        public IEnumerable<T> GetAll()
        {
            return _appilicationDBContext.Set<T>().ToList();
        }

        public T GetById(int id)
        {
            return _appilicationDBContext.Set<T>().Find(id);
        }

        public void Remove(T entity)
        {
            _appilicationDBContext.Set<T>().Remove(entity);
        }

        public void RemoveRange(IEnumerable<T> entities)
        {
            _appilicationDBContext.Set<T>().RemoveRange();
        }
    }
}
