using RoadMapApp.Data;
using RoadMapApp.utils.Repository;
using RoadMapApp.Models;
using RoadMapApp.utils.Repository.ModuleRepository;

namespace RoadMapApp.Repository.SectionRepository;

public class SectionRepository: ModuleRepository<Section>, ISectionRepository
{
    public SectionRepository(DataContext context) : base(context, context.Sections)
    {
    }
    
    protected override void SetContextEntry(Section item)
    {
        SetEntry(item.Next);
        SetEntry(item.Options);
    }

    protected override IQueryable<Section> SetIncluded()
    {
        return Table
            .Include(task => task.Options)
            .ThenInclude(option => option.Choices)
            .Include(task => task.Next);
    }
}