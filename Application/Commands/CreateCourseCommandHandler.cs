using MediatR;
using OnlineLearningPlatform.Domain;
using OnlineLearningPlatform.Infrastructure;

namespace OnlineLearningPlatform.Application.Commands;

public class CreateCourseCommandHandler : IRequestHandler<CreateCourseCommand, int>
{
    private readonly ICourseRepository _courseRepository;

    public CreateCourseCommandHandler(ICourseRepository courseRepository)
    {
        _courseRepository = courseRepository;
    }

    public async Task<int> Handle(CreateCourseCommand request, CancellationToken cancellationToken)
    {
        var course = new Course
        {
            Title = request.Title,
            Description = request.Description,
            InstructorId = request.InstructorId
        };

        await _courseRepository.AddAsync(course);
        await _courseRepository.SaveChangesAsync();

        return course.Id;
    }
}
