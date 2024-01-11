using RoadMapApp.utils.Module;

namespace RoadMapApp.Models;

public class Action: NextModule<Action>
{
    public string Title { get; set; }
    public string Description { get; set; }
    public List<Task> Tasks { get; set; }
    
    // relation prop
    public List<ActionStudent> ActionStudents { get; set; } = new List<ActionStudent>();
}