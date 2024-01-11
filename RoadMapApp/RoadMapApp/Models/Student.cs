using RoadMapApp.utils.Module;

namespace RoadMapApp.Models;

public class Student: BaseModule<Student>
{
    public List<Choice> Choices { get; set; } = new List<Choice>();
    public List<RoadmapStudent> RoadmapStudents { get; set; } = new List<RoadmapStudent>();
    public List<ActionStudent> ActionStudents { get; set; } = new List<ActionStudent>();
}