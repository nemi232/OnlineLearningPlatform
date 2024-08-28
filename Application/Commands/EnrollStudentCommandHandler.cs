// Application/Commands/EnrollStudentCommandHandler.cs

using MediatR;
using OnlineLearningPlatform.Application.Commands;
using OnlineLearningPlatform.Domain;
using OnlineLearningPlatform.Infrastructure;

public class EnrollStudentCommandHandler : IRequestHandler<EnrollStudentCommand>
{
    private readonly IStudentRepository _studentRepository;

    public EnrollStudentCommandHandler(IStudentRepository studentRepository)
    {
        _studentRepository = studentRepository;
    }

    public async Task<Unit> Handle(EnrollStudentCommand request, CancellationToken cancellationToken)
    {
        var student = await _studentRepository.GetByIdAsync(request.StudentId);
        var course = await _studentRepository.GetCourseByIdAsync(request.CourseId);

        if (student != null && course != null)
        {
            student.Enrollments.Add(new Enrollment
            {
                CourseId = course.Id,
                StudentId = student.Id,
                CompletedLessons = new List<Lesson>()
            });

            await _studentRepository.SaveChangesAsync();
        }

        return Unit.Value;
    }
}