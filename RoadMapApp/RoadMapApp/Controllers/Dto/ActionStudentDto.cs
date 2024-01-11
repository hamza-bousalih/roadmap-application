using System.Text.Json.Serialization;
using RoadMapApp.Models.Enums;
using RoadMapApp.utils.Dto;

namespace RoadMapApp.Controllers.Dto;

public class ActionStudentDto:BaseAssociationDto
{
    public StudentDto Student { get; set; }
    public ActionDto Action { get; set; }

    public string Status { get; set; }
}