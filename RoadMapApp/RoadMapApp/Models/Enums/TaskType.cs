﻿using System.Text.Json.Serialization;

namespace RoadMapApp.Models.Enums;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum TaskType
{
    Watch,
    Read,
    Write,
    Code,
    Listen,
    Qcm
}