using RoadMapApp.Data;
using RoadMapApp.Models;
using RoadMapApp.utils.Repository.AssociationModuleRepository;

namespace RoadMapApp.Repository.TaskStudentRepository;

public class TaskStudentRepository : AssociationModuleRepository<TaskStudent>, ITaskStudentRepository
{

    public TaskStudentRepository(DataContext context) : base(context, context.TaskStudents)
    {
    }

    protected override void SetContextEntry(TaskStudent item)
    {
        SetEntry(item.Task);
        SetEntry(item.Student);
    }

    protected override IQueryable<TaskStudent> SetIncluded()
    {
        return Table
            .Include(rs => rs.Task)
            .Include(rs => rs.Student);
    }

    public async Task<int> DeleteByTask(int id) => await Delete(i => i.TaskId == id);

    public async Task<int> DeleteByStudent(int id) => await Delete(i => i.StudentId == id);
    
    public async Task<List<TaskStudent>> FindByTask(int id) => await Filter(rs => rs.StudentId == id);

    public async Task<List<TaskStudent>> FindByStudent(int id) => await Filter(rs => rs.StudentId == id);
}