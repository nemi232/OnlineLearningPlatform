using Microsoft.EntityFrameworkCore;
using OnlineLearningPlatform.Domain;

namespace OnlineLearningPlatform.Infrastructure;

public class CourseRepository : ICourseRepository
{
    private readonly ApplicationDbContext _context;

    public CourseRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task AddAsync(Course course)
    {
        await _context.Courses.AddAsync(course);
    }

    public async Task<Course> GetByIdAsync(int id)
    {
        return await _context.Courses.Include(c => c.Lessons).FirstOrDefaultAsync(c => c.Id == id);
    }

    public async Task<IEnumerable<Course>> GetAllAsync()
    {
        return await _context.Courses.ToListAsync();
    }

    public async Task SaveChangesAsync()
    {
        await _context.SaveChangesAsync();
    }
}