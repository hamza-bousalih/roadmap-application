using RoadMapApp.Data;
using RoadMapApp.utils.Repository.ModuleRepository;
using Action = RoadMapApp.Models.Action;
namespace RoadMapApp.Repository.ActionRepository;

public class ActionRepository: ModuleRepository<Action>, IActionRepository
{
    public ActionRepository(DataContext context) : base(context, context.Actions)
    {
    }

    protected override void SetContextEntry(Action item)
    {
        SetEntry(item.Next);
    }

    protected override IQueryable<Action> SetIncluded()
    {
        return Table
            .Include(action => action.Tasks)
            .Include(action => action.ActionStudents)
                .ThenInclude(actionStudent => actionStudent.Student);
    }
}