namespace LikeToDo.Models;

public class TodoList
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public int? GroupId { get; set; }
    public Group? Group { get; set; }
    public int UserId  { get; set; }
    public User? User { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    public ICollection<TodoTask> TodoTasks { get; set; } = new List<TodoTask>();
}