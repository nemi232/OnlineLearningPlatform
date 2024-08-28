using Microsoft.EntityFrameworkCore;
using OnlineLearningPlatform.Domain;

namespace OnlineLearningPlatform.Infrastructure;

// Infrastructure/Repositories/StudentRepository.cs
public class StudentRepository : IStudentRepository
{
    private readonly ApplicationDbContext _context;

    public StudentRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<Student> GetByIdAsync(int id)
    {
        return await _context.Students
            .Include(s => s.Enrollments)
            .ThenInclude(e => e.CompletedLessons)
            .FirstOrDefaultAsync(s => s.Id == id);
    }

    public async Task<IEnumerable<Student>> GetAllAsync()
    {
        return await _context.Students
            .Include(s => s.Enrollments)
            .ToListAsync();
    }

    public async Task AddAsync(Student student)
    {
        await _context.Students.AddAsync(student);
    }

    public async Task SaveChangesAsync()
    {
        await _context.SaveChangesAsync();
    }

    public async Task<Course> GetCourseByIdAsync(int courseId)
    {
        return await _context.Courses
            .Include(c => c.Lessons)
            .FirstOrDefaultAsync(c => c.Id == courseId);
    }
}
