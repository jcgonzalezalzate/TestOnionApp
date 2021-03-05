using TestOnionApp.Domain.Interfaces.Services;

namespace TestOnionApp.Application.Services
{
    using Domain.Entities;
    using Generics;
    using Interfaces;

    public class TeacherApplication : GenericApplication<Teacher>, ITeacherApplication
    {
        public TeacherApplication(IGenericService<Teacher> genericService) : base(genericService)
        {
        }
    }
}
