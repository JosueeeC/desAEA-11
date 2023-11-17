using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Models
{
    public class SchoolContext : DbContext
    {

        public SchoolContext(DbContextOptions<SchoolContext> options) : base(options) { }

        public DbSet<Student> Students { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Grade> Grades { get; set; }
        public DbSet<Course> Courses { get; set; }
    }
}

