using RoadMapApp.utils.Dto;

namespace RoadMapApp.Controllers.Dto;

public class SectionDto: BaseDto
{
    public SectionDto Next { get; set; }
    public List<OptionDto> Options { get; set; }
}