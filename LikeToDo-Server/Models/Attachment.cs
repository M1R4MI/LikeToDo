using LikeToDo.Models;

public class Attachment
{
    public int Id { get; set; }
    public string FilePath { get; set; } = string.Empty;
    public string FileName { get; set; } = string.Empty;
    public long FileSize { get; set; }
    public DateTime UploadDate { get; set; } = DateTime.UtcNow;
    public int TaskId { get; set; }
    public TodoTask? TodoTask { get; set; }
}