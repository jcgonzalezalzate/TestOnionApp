using TestOnionApp.Domain.Interfaces.Services;

namespace TestOnionApp.Application.Services
{
    using Domain.Entities;
    using Generics;
    using Interfaces;

    public class StudentApplication : GenericApplication<Student>, IStudentApplication
    {
        public StudentApplication(IGenericService<Student> genericService) : base(genericService)
        {
        }
    }
}
