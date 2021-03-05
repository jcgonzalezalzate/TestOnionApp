namespace TestOnionApp.Infrastructure.Repo
{
    using Domain.Entities;
    using Generics;
    using Domain.Interfaces.Repositories;

    public class StudentRepository : GenericRepository<Student>, IStudentRepository
    {
        public StudentRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
        }
    }
}
