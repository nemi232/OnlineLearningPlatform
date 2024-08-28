namespace OnlineLearningPlatform.Application.Dto;

// Application/Dtos/CourseDto.cs
public class CourseDto
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public List<LessonDto> Lessons { get; set; } = new();
}
