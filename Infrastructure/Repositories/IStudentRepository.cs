using OnlineLearningPlatform.Domain;

namespace OnlineLearningPlatform.Infrastructure;

// Infrastructure/Repositories/IStudentRepository.cs
public interface IStudentRepository
{
    Task<Student> GetByIdAsync(int id);
    Task<IEnumerable<Student>> GetAllAsync();
    Task AddAsync(Student student);
    Task SaveChangesAsync();
    Task<Course> GetCourseByIdAsync(int courseId);
}
