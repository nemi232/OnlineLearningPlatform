using OnlineLearningPlatform.Domain;

namespace OnlineLearningPlatform.Infrastructure;

public interface ICourseRepository
{
    Task AddAsync(Course course);
    Task<Course> GetByIdAsync(int id);
    Task<IEnumerable<Course>> GetAllAsync();
    Task SaveChangesAsync();
}