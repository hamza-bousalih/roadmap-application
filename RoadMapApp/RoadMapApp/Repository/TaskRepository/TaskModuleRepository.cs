using RoadMapApp.Data;
using RoadMapApp.utils.Repository;
using RoadMapApp.utils.Repository.ModuleRepository;
using Task = RoadMapApp.Models.Task;

namespace RoadMapApp.Repository.TaskRepository;

public class TaskRepository: ModuleRepository<Task>, ITaskRepository
{
    public TaskRepository(DataContext context) : base(context, context.Tasks)
    {
    }
    
    protected override void SetContextEntry(Task item)
    {
        SetEntry(item.Action);
    }

    protected override IQueryable<Task> SetIncluded()
    {
        return Table
            .Include(task => task.Action)
            .ThenInclude(action => action.ActionStudents);
    }
}