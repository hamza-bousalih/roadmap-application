using RoadMapApp.utils.Module;

namespace RoadMapApp.Models;

public class Admin: BaseModule<Admin>
{
    
    // relation prop
    public List<Roadmap> Roadmaps { get; set; } = new List<Roadmap>();
}