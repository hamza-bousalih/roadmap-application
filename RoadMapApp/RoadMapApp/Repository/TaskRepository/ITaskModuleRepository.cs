using RoadMapApp.utils.Repository;
using RoadMapApp.utils.Repository.ModuleRepository;
using Task = RoadMapApp.Models.Task;

namespace RoadMapApp.Repository.TaskRepository;

public interface ITaskRepository: IModuleRepository<Task>
{
}