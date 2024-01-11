using RoadMapApp.utils.Dto;
using TaskStatus = RoadMapApp.Models.Enums.TaskStatus;

namespace RoadMapApp.Controllers.Dto;

public class TaskStudentDto:BaseAssociationDto
{
    public StudentDto Student { get; set; }
    public TaskDto Task { get; set; }

    public string Status { get; set; }
}