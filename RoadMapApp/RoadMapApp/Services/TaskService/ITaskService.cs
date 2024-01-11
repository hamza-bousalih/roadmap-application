using RoadMapApp.utils.service;
using RoadMapApp.utils.service.ModuleService;
using Task = RoadMapApp.Models.Task;

namespace RoadMapApp.Services.TaskService;

public interface ITaskService: IModuleService<Task>
{
}