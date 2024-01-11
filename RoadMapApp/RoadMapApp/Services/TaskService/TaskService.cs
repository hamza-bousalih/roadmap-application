using Lamar;
using RoadMapApp.Repository.TaskRepository;
using RoadMapApp.utils.service;
using RoadMapApp.utils.service.ModuleService;
using Task = RoadMapApp.Models.Task;

namespace RoadMapApp.Services.TaskService;

public class TaskService: ModuleService<Task, ITaskRepository>, ITaskService
{
    public TaskService(IContainer container): base(container)
    {
    }
}