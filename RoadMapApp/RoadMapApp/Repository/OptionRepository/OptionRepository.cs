using RoadMapApp.Data;
using RoadMapApp.utils.Repository;
using RoadMapApp.utils.Repository.ModuleRepository;
using Option = RoadMapApp.Models.Option;

namespace RoadMapApp.Repository.OptionRepository;

public class OptionRepository : ModuleRepository<Option>, IOptionRepository
{
    public OptionRepository(DataContext context) : base(context, context.Options)
    {
    }
    
    protected override void SetContextEntry(Option item)
    {
        SetEntry(item.Section);
        SetEntry(item.Start);
    }

    protected override IQueryable<Option> SetIncluded()
    {
        return Table
            .Include(o => o.Start)
            .ThenInclude(a => a.Tasks)
            .Include(o => o.Section)
            .Include(option => option.Choices)
            .ThenInclude(s => s.Student)
            
            ;
    }
}