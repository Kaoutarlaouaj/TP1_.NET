using System;
using System.Threading.Tasks;

namespace TP1_.Net.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly SchoolContext _context;

        public IRepository<Person> Persons { get; }
        public IRepository<Student> Students { get; }
        public IRepository<Teacher> Teachers { get; }
        public IRepository<Class> Classes { get; }
        public IRepository<Subject> Subjects { get; }
        public IRepository<Enrollment> Enrollments { get; }

        public UnitOfWork(SchoolContext context)
        {
            _context = context;
            Persons = new Repository<Person>(context);
            Students = new Repository<Student>(context);
            Teachers = new Repository<Teacher>(context);
            Classes = new Repository<Class>(context);
            Subjects = new Repository<Subject>(context);
            Enrollments = new Repository<Enrollment>(context);
        }

        public async Task<int> CompleteAsync() => await _context.SaveChangesAsync();

        public void Dispose() => _context.Dispose();
    }
}
