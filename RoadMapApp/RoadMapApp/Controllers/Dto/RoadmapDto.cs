using RoadMapApp.utils.Dto;

namespace RoadMapApp.Controllers.Dto;

public class RoadmapDto : BaseDto
{
    public string Title { get; set; }
    public string Description { get; set; }

    public SectionDto Start { get; set; }
    
    public AdminDto Admin { get; set; }
    public List<RoadmapStudentDto> RoadmapStudents { get; set; } = new List<RoadmapStudentDto>();
}