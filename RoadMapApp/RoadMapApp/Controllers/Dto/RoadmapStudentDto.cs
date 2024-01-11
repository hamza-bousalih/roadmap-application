using RoadMapApp.Models.Enums;
using RoadMapApp.utils.Dto;

namespace RoadMapApp.Controllers.Dto;

public class RoadmapStudentDto:BaseAssociationDto
{
    public StudentDto Student { get; set; }
    public RoadmapDto Roadmap { get; set; }
    
    public string Status { get; set; }
}