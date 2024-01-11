using RoadMapApp.Models.Enums;
using RoadMapApp.utils.Module;

namespace RoadMapApp.Models;

public class RoadmapStudent: BaseAssociationModule<RoadmapStudent>
{
    public Student Student { get; set; }
    public Roadmap Roadmap { get; set; }
    
    public int StudentId { get; set; }
    public int RoadmapId { get; set; }

    public RoadmapStatus Status { get; set; }
    
    public override bool Equals(RoadmapStudent obj) => 
        obj.StudentId == StudentId && obj.RoadmapId == RoadmapId;
    
    public override bool NoNull() =>
        StudentId == 0 && RoadmapId == 0;
}