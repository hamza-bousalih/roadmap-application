using Lamar;
using RoadMapApp.Repository.ActionRepository;
using RoadMapApp.utils.service.ModuleService;
using Action = RoadMapApp.Models.Action;

namespace RoadMapApp.Services.ActionService;

public class ActionService: ModuleService<Action, IActionRepository>, IActionService
{
    public ActionService(IContainer container): base(container)
    {
    }
}