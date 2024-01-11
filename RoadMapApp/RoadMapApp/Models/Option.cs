using RoadMapApp.utils.Module;

namespace RoadMapApp.Models;

public class Option: BaseModule<Option>
{
    public string Title { get; set; }
    public string Description { get; set; }
    public Action Start { get; set; }
    
    // relation 
    public Section Section { get; set; }
    public HashSet<Choice> Choices { get; set; } = new HashSet<Choice>();
}