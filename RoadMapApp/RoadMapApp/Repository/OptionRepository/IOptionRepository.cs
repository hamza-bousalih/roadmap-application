using RoadMapApp.utils.Repository;
using RoadMapApp.utils.Repository.ModuleRepository;
using Option = RoadMapApp.Models.Option;

namespace RoadMapApp.Repository.OptionRepository;

public interface IOptionRepository : IModuleRepository<Option>
{
}