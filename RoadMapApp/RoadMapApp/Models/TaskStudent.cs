using RoadMapApp.utils.Module;
using TaskStatus = RoadMapApp.Models.Enums.TaskStatus;

namespace RoadMapApp.Models;

public class TaskStudent: BaseAssociationModule<TaskStudent>
{
    public Student Student { get; set; }
    public Task Task { get; set; }
    
    public int StudentId { get; set; }
    public int TaskId { get; set; }

    public TaskStatus Status { get; set; }

    public override bool Equals(TaskStudent obj) => 
        obj.StudentId == StudentId && obj.TaskId == TaskId;

    public override bool NoNull() =>
        StudentId == 0 && TaskId == 0;
}