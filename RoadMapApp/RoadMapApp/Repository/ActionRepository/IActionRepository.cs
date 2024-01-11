using RoadMapApp.utils.Repository;
using RoadMapApp.utils.Repository.ModuleRepository;
using Action = RoadMapApp.Models.Action;

namespace RoadMapApp.Repository.ActionRepository;

public interface IActionRepository: IModuleRepository<Action>
{
}