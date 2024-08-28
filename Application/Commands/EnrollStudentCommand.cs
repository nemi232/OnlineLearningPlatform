using MediatR;

namespace OnlineLearningPlatform.Application.Commands;

public record EnrollStudentCommand(int StudentId, int CourseId) : IRequest;
