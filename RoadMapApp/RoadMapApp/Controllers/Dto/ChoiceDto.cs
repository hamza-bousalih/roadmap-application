using RoadMapApp.utils.Dto;

namespace RoadMapApp.Controllers.Dto;

public class ChoiceDto:BaseAssociationDto
{
    public StudentDto Student { get; set; }
    public OptionDto Option { get; set; }
}