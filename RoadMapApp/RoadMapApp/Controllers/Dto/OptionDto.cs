using RoadMapApp.utils.Dto;

namespace RoadMapApp.Controllers.Dto;

public class OptionDto: BaseDto
{
    public string Title { get; set; }
    public string Description { get; set; }
    public ActionDto Start { get; set; }
    
    public SectionDto Section { get; set; }
    public List<ChoiceDto> Choices { get; set; } = new List<ChoiceDto>();
}