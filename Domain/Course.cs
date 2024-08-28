namespace OnlineLearningPlatform.Domain;

public class Course
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public int InstructorId { get; set; }
    public List<Lesson> Lessons { get; set; } = new();
}
