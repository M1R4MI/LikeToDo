namespace LikeToDo.Models;

public class Reminder
{
    public int Id { get; set; }
    public DateTime ReminderTime { get; set; }
    public bool IsTriggered { get; set; }
    public int TaskId { get; set; }
    public TodoTask? TodoTask { get; set; }
}