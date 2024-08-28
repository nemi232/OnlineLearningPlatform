using MediatR;

namespace OnlineLearningPlatform.Application.Commands;

public record CreateCourseCommand(string Title, string Description, int InstructorId) : IRequest<int>;
