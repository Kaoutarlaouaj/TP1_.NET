using System.Security.Claims;
using System;
using Microsoft.EntityFrameworkCore;

namespace TP1_.Net
{
    public class SchoolContext : DbContext
    {
        public DbSet<Person> Persons { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Class> Classes { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=SchoolDB;Username=postgres;Password=postgres;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>()
                .HasOne<Person>()
                .WithMany()
                .HasForeignKey(s => s.PersonId);

            modelBuilder.Entity<Teacher>()
                .HasOne<Person>()
                .WithMany()
                .HasForeignKey(t => t.PersonId);

            modelBuilder.Entity<Class>()
                .HasOne<Teacher>()
                .WithMany()
                .HasForeignKey(c => c.TeacherId);

            modelBuilder.Entity<Enrollment>()
                .HasOne<Student>()
                .WithMany()
                .HasForeignKey(e => e.StudentId);

            modelBuilder.Entity<Enrollment>()
                .HasOne<Class>()
                .WithMany()
                .HasForeignKey(e => e.ClassId);
        }
    }

}
