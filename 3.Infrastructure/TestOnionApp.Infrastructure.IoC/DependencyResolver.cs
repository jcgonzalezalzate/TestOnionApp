using Microsoft.Extensions.DependencyInjection;
using TestOnionApp.Application.Interfaces;
using TestOnionApp.Application.Interfaces.Generics;
using TestOnionApp.Application.Services;
using TestOnionApp.Application.Services.Generics;
using TestOnionApp.Domain.Entities;
using TestOnionApp.Domain.Interfaces;
using TestOnionApp.Domain.Interfaces.Repositories;
using TestOnionApp.Domain.Interfaces.Services;
using TestOnionApp.Domain.Interfaces.Services;
using TestOnionApp.Domain.Services;
using TestOnionApp.Domain.Services.Generics;
using TestOnionApp.Infrastructure.Repo;
using TestOnionApp.Infrastructure.Repo.Generics;

namespace TestOnionApp.Infrastructure.IoC
{
    public class DependencyResolver
    {
        public IServiceCollection GetServiceCollection()
        {
            IServiceCollection services = new ServiceCollection();
            services.AddTransient<IStudentApplication, StudentApplication>();
            services.AddTransient<IStudentRepository, StudentRepository>();
            services.AddTransient<IGenericRepository<Student>, GenericRepository<Student>>();
            services.AddTransient<IGenericService<Student>, GenericService<Student>>();
            services.AddTransient<IGenericApplication<Student>, GenericApplication<Student>>();

            services.AddTransient<ITeacherApplication, TeacherApplication>();
            services.AddTransient<ITeacherService, TeacherService>();
            services.AddTransient<IGenericRepository<Teacher>, GenericRepository<Teacher>>();
            services.AddTransient<IGenericService<Teacher>, TeacherService>();
            services.AddTransient<IGenericApplication<Teacher>, GenericApplication<Teacher>>();

            return services;
        }
    }
}
