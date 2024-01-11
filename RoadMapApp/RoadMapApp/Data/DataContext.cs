using System.Reflection;
using RoadMapApp.Models;
using Action = RoadMapApp.Models.Action;
using Task = RoadMapApp.Models.Task;

namespace RoadMapApp.Data;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }

    protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
    {
        configurationBuilder.Properties<string>().HaveMaxLength(150);
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.EnableSensitiveDataLogging();
    }

    public DbSet<Roadmap> Roadmaps { get; init; }
    public DbSet<Section> Sections { get; init; }
    public DbSet<Option> Options { get; init; }
    public DbSet<Action> Actions { get; init; }
    public DbSet<Task> Tasks { get; init; }

    public DbSet<Admin> Admins { get; init; }
    public DbSet<User> Users { get; init; }

    public DbSet<Student> Students { get; init; }
    public DbSet<Choice> Choices { get; init; }
    public DbSet<ActionStudent> ActionStudents { get; init; }
    public DbSet<RoadmapStudent> RoadmapStudents { get; init; }
    public DbSet<TaskStudent> TaskStudents { get; init; }
}