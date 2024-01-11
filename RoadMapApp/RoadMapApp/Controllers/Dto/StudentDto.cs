using RoadMapApp.utils.Dto;

namespace RoadMapApp.Controllers.Dto;

public class StudentDto:BaseDto
{
    public List<ChoiceDto> Choices { get; set; } = new List<ChoiceDto>();
    public List<RoadmapStudentDto> RoadmapStudents { get; set; } = new List<RoadmapStudentDto>();
    public List<ActionStudentDto> ActionStudents { get; set; } = new List<ActionStudentDto>();
}