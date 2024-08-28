using Microsoft.EntityFrameworkCore;
using OnlineLearningPlatform.Domain;

namespace OnlineLearningPlatform.Infrastructure;

// Infrastructure/ApplicationDbContext.cs
public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

    public DbSet<Course> Courses { get; set; }
    public DbSet<Student> Students { get; set; }
    public DbSet<Enrollment> Enrollments { get; set; }
    public DbSet<Lesson> Lessons { get; set; }
}
