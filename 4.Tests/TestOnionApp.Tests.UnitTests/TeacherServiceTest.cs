using TestOnionApp.Domain.Interfaces.Repositories;

namespace TestOnionApp.Tests.UnitTests
{
    using System;
    using Moq;
    using Xunit;
    using Domain.Entities;
    using TestOnionApp.Domain.Services;

    public class TeacherServiceTest : IDisposable

    {
        private MockRepository mockRepository;

        private Mock<IGenericRepository<Teacher>> mockGenericRepository;

        public TeacherServiceTest()
        {
            mockRepository = new MockRepository(MockBehavior.Strict);

            mockGenericRepository = mockRepository.Create<IGenericRepository<Teacher>>();
        }

        private TeacherService CreateTeacherServiceInstance()
        {
            return new TeacherService(mockGenericRepository.Object);
        }

        [Theory]
        [InlineData(1989, 32)]
        [InlineData(1979, 42)]
        [InlineData(1969, 52)]
        [InlineData(1959, 62)]

        public void TeacherService_TeacherBirthDateIs_TeacherAgeIs(int birthDateSetted, int ageExpected)
        {
            var teacherService = CreateTeacherServiceInstance();

            var entity = new Teacher {BirthDate = new DateTime(birthDateSetted, 12, 12)};
            mockGenericRepository.Setup(s => s.Create(entity)).Returns(entity);

            var teacher = teacherService.Create(entity);

            Assert.Equal(ageExpected, teacher.Age);
        }

        public void Dispose()
        {
            mockRepository.VerifyAll();
        }
    }
}
