namespace LikeToDo.Models;

public class Group
{
    public int Id { get; set; }
    public string name { get; set; } = string.Empty;
    public int UserId { get; set; }
    public User? User { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    public ICollection<TodoList> TodoLists { get; set; } = new List<TodoList>();
}