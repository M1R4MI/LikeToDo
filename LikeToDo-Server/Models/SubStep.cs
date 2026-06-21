namespace LikeToDo.Models;

public class SubStep
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public bool IsCompleted { get; set; }
    public int TaskId { get; set; }
    public TodoTask? TodoTask { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
}