namespace OnlineLearningPlatform.Domain;

public class Enrollment
{
    public int Id { get; set; }
    public int CourseId { get; set; }
    public int StudentId { get; set; }
    public List<Lesson> CompletedLessons { get; set; } = new();
}