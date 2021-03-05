namespace TestOnionApp.Infrastructure.Repo.Generics
{
    using Domain.Interfaces.Repositories;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Linq.Expressions;
    using TestOnionApp.Domain.Entities.Generics;

    public class GenericRepository<T> : IGenericRepository<T> where T : GenericEntity
    {
        public RepositoryContext RepositoryContext { get; set; }

        public GenericRepository(RepositoryContext repositoryContext)
        {
            RepositoryContext = repositoryContext;
        }

        public List<T> GetAll()
        {
            return RepositoryContext.Set<T>().ToList();
        }

        public T Details(Expression<Func<T, bool>> expression)
        {
            var query = RepositoryContext.Set<T>().AsQueryable();
            
            return query.Where(expression).FirstOrDefault();
        }

        public T Create(T entity)
        {
            RepositoryContext.Set<T>().Add(entity);
            RepositoryContext.SaveChanges();
            return entity;
        }

        public T Edit(T entity)
        {
            RepositoryContext.Update(entity);
            RepositoryContext.SaveChanges();
            return entity;
        }

        public T Delete(int id)
        {
            T entityDelete = RepositoryContext.Set<T>().Find(id);
            RepositoryContext.Set<T>().Remove(entityDelete);
            RepositoryContext.SaveChanges();
            return entityDelete;
        }
    }
}
