using System.Text.RegularExpressions;

namespace LikeToDo.Models;

public class User
{
    public int Id { get; set; }
    public string Username { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string PasswordHash { get; set; } = string.Empty;
    public DateTime WhenCreated { get; set; } = DateTime.UtcNow;

    public ICollection<Group> Groups { get; set; } = new List<Group>();
    public ICollection<TodoList> TodoLists { get; set; } = new List<TodoList>();
}