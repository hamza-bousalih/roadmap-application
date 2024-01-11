using RoadMapApp.utils.Module;

namespace RoadMapApp.Models;

public class Roadmap: BaseModule<Roadmap>
{
    public string Title { get; set; }
    public string Description { get; set; }
    public Section Start { get; set; }
    
    // relation prop
    public Admin Admin { get; set; }

    public List<RoadmapStudent> RoadmapStudents { get; set; } = new List<RoadmapStudent>();

    public override Roadmap Optimized()
    {
        var id = Id;
        var title = Title;
        return new Roadmap
        {
            Id = id,
            Title = title
        };
    }
}