using System;
using System.Threading.Tasks;

namespace TP1_.Net.Repositories
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<Person> Persons { get; }
        IRepository<Student> Students { get; }
        IRepository<Teacher> Teachers { get; }
        IRepository<Class> Classes { get; }
        IRepository<Subject> Subjects { get; }
        IRepository<Enrollment> Enrollments { get; }
        Task<int> CompleteAsync();
    }
}
