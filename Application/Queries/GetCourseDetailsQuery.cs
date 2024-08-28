using MediatR;
using OnlineLearningPlatform.Application.Dto;

namespace OnlineLearningPlatform.Application.Queries;

public record GetCourseDetailsQuery(int CourseId) : IRequest<CourseDto>;
