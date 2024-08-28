using MediatR;
using OnlineLearningPlatform.Application.Dto;
using OnlineLearningPlatform.Infrastructure;

namespace OnlineLearningPlatform.Application.Queries;

public class ListCoursesQueryHandler : IRequestHandler<ListCoursesQuery, IEnumerable<CourseDto>>
{
    private readonly ICourseRepository _courseRepository;

    public ListCoursesQueryHandler(ICourseRepository courseRepository)
    {
        _courseRepository = courseRepository;
    }

    public async Task<IEnumerable<CourseDto>> Handle(ListCoursesQuery request, CancellationToken cancellationToken)
    {
        var courses = await _courseRepository.GetAllAsync();

        return courses.Select(c => new CourseDto
        {
            Id = c.Id,
            Title = c.Title,
            Description = c.Description
        });
    }

}