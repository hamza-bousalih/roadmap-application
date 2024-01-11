using RoadMapApp.Models.Enums;
using RoadMapApp.utils.Dto;
using System.Text.Json.Serialization;

namespace RoadMapApp.Controllers.Dto;
public class TaskDto: BaseDto
{
    public string Title { get; set; }
    public string Description { get; set; }
    public string Link { get; set; }
    
    public string Type { get; set; }
    public ActionDto Action { get; set; }
}