using System.Text.Json.Serialization;

namespace RoadMapApp.Models.Enums;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum RoadmapStatus
{
    Current,
    Finish,
    Stopped,
    Rejected
}