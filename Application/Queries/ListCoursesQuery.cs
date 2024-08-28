using MediatR;
using OnlineLearningPlatform.Application.Dto;

namespace OnlineLearningPlatform.Application.Queries;

public record ListCoursesQuery : IRequest<IEnumerable<CourseDto>>;
