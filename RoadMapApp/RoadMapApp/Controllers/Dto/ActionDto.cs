using RoadMapApp.utils.Dto;

namespace RoadMapApp.Controllers.Dto;

public class ActionDto: BaseDto
{
    public string Title { get; set; }
    public string Description { get; set; }
    public ActionDto Next { get; set; }
    public List<TaskDto> Tasks { get; set; }
    
    public List<ActionStudentDto> ActionStudents { get; set; } = new List<ActionStudentDto>();
}