using Microsoft.EntityFrameworkCore;
using LikeToDo.Models;

namespace LikeToDo.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
    {
    }

    public DbSet<TodoTask> Tasks { get; set; }
}