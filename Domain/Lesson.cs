namespace OnlineLearningPlatform.Domain;

public class Lesson
{
    public int Id { get; set; }
    public string Title { get; set; }
    public bool IsCompleted { get; set; }
    public int CourseId { get; set; }
}