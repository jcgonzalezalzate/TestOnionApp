using System.Collections.Generic;
using TestOnionApp.Domain.Entities.Generics;
using TestOnionApp.Domain.Interfaces.Repositories;
using TestOnionApp.Domain.Interfaces.Services;

namespace TestOnionApp.Domain.Services.Generics
{
    public class GenericService<T> : IGenericService<T> where T : GenericEntity
    {
        public IGenericRepository<T> GenericRepository { get; set; }

        public GenericService(IGenericRepository<T> genericRepository)
        {
            GenericRepository = genericRepository;
        }

        public virtual List<T> GetAll()
        {
            return GenericRepository.GetAll();
        }

        public virtual T Details(int id)
        {
            return GenericRepository.Details(i => i.Id == id);
        }

        public virtual T Create(T entity)
        {
            return GenericRepository.Create(entity);
        }

        public virtual T Edit(T entity)
        {
            return GenericRepository.Edit(entity);
        }

        public virtual T Delete(int id)
        {
            return GenericRepository.Delete(id);
        }
    }
}
