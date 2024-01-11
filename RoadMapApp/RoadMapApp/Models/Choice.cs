using RoadMapApp.utils.Module;

namespace RoadMapApp.Models;

public class Choice: BaseAssociationModule<Choice>
{
    public Student Student { get; set; }
    public Option Option { get; set; }
    
    public int StudentId { get; set; }
    public int OptionId { get; set; }
    
    public override bool Equals(Choice obj) => 
        obj.StudentId == StudentId && obj.OptionId == OptionId;
    public override bool NoNull() =>
        StudentId == 0 && OptionId == 0;
}