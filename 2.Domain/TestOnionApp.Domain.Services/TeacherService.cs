using TestOnionApp.Domain.Interfaces.Repositories;
using TestOnionApp.Domain.Interfaces.Services;

namespace TestOnionApp.Domain.Services
{
    using System;
    using TestOnionApp.Domain.Entities;
    using TestOnionApp.Domain.Interfaces;
    using TestOnionApp.Domain.Services.Generics;

    public class TeacherService : GenericService<Teacher>, ITeacherService
    {
        public TeacherService(IGenericRepository<Teacher> genericRepository) : base(genericRepository)
        {
        }

        public override Teacher Create(Teacher entity)
        {
            entity.Age = DateTime.Now.Year - entity.BirthDate.Year;
            return base.Create(entity);
        }

        public override Teacher Details(int id)
        {
            var entity = base.Details(id);
            if (entity.Age.HasValue)
            {
                entity.BirthDate = DateTime.Now.AddYears(entity.Age.Value * -1);
            }
            return entity;
        }

        public override Teacher Edit(Teacher entity)
        {
            entity.Age = DateTime.Now.Year - entity.BirthDate.Year;
            return base.Edit(entity);
        }
    }
}
