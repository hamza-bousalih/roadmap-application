using RoadMapApp.Models.Enums;
using RoadMapApp.utils.Module;

namespace RoadMapApp.Models;

public class Task:BaseModule<Task>
{
    public string Title { get; set; }
    public string Description { get; set; }
    public string Link { get; set; }
    public TaskType Type { get; set; }

    // relation prop
    public Action Action { get; set; }
}