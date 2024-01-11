using RoadMapApp.utils.Module;

namespace RoadMapApp.Models;

public class Section: NextModule<Section>
{ 
    public List<Option> Options { get; set; }
}