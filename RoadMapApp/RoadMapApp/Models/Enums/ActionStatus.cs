using System.Text.Json.Serialization;

namespace RoadMapApp.Models.Enums;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum ActionStatus
{
    Current,
    Done,
    NotYet,
}