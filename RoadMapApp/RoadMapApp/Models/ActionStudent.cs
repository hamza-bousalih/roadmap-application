using RoadMapApp.Models.Enums;
using RoadMapApp.utils.Module;

namespace RoadMapApp.Models;

public class ActionStudent: BaseAssociationModule<ActionStudent>
{
    public Student Student { get; set; }
    public Action Action { get; set; }
    
    public int StudentId { get; set; }
    public int ActionId { get; set; }

    public ActionStatus Status { get; set; }

    public override bool Equals(ActionStudent obj) => 
        obj.StudentId == StudentId && obj.ActionId == ActionId;

    public override bool NoNull() =>
        StudentId == 0 && ActionId == 0;
}