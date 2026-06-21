namespace LikeToDo.Models;

public  class TodoTask
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string? Description { get; set;}
    public bool IsCompleted { get; set; }
    public bool IsImportant { get; set; }
    public DateTime? DueDate { get; set; }
    public int ListId { get; set; }
    public TodoList? TodoList { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    public ICollection<SubStep> SubSteps { get; set; } = new List<SubStep>();
    public ICollection<Reminder> Reminders { get; set; } = new List<Reminder>();
    public ICollection<Attachment> Attachments { get; set; } = new List<Attachment>();
}