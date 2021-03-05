namespace TestOnionApp.Infrastructure.Repo.Generics
{
    using Microsoft.EntityFrameworkCore;
    using Domain.Entities;


    public class RepositoryContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        
        public DbSet<Teacher> Teachers{ get; set; }

        public RepositoryContext(DbContextOptions<RepositoryContext> options)
            : base(options)
        {
        
        }
    }
}
