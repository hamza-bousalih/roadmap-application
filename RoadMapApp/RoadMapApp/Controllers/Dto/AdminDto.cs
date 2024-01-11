using RoadMapApp.utils.Dto;

namespace RoadMapApp.Controllers.Dto;

public class AdminDto: BaseDto
{
    public List<RoadmapDto> Roadmaps { get; set; } = new List<RoadmapDto>();
}