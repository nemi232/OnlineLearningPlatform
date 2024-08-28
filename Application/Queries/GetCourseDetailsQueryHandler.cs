using MediatR;
using OnlineLearningPlatform.Application.Dto;
using OnlineLearningPlatform.Infrastructure;

namespace OnlineLearningPlatform.Application.Queries;

public class GetCourseDetailsQueryHandler : IRequestHandler<GetCourseDetailsQuery, CourseDto>
{
    private readonly ICourseRepository _courseRepository;

    public GetCourseDetailsQueryHandler(ICourseRepository courseRepository)
    {
        _courseRepository = courseRepository;
    }

    public async Task<CourseDto> Handle(GetCourseDetailsQuery request, CancellationToken cancellationToken)
    {
        var course = await _courseRepository.GetByIdAsync(request.CourseId);

        if (course == null) return null;

        return new CourseDto
        {
            Id = course.Id,
            Title = course.Title,
            Description = course.Description,
            Lessons = course.Lessons.Select(l => new LessonDto { Id = l.Id, Title = l.Title }).ToList()
        };
    }
}