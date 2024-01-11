using Lamar;
using RoadMapApp.Models;
using RoadMapApp.Repository.TaskStudentRepository;
using RoadMapApp.utils.service.AssociationService;

namespace RoadMapApp.Services.TaskStudentService;

public class TaskStudentService : AssociationService<TaskStudent, ITaskStudentRepository>, ITaskStudentService
{
    public TaskStudentService(IContainer container): base(container)
    {
    }

    public async Task<int> DeleteByTask(int id) => await Repository.DeleteByTask(id);

    public async Task<int> DeleteByStudent(int id) => await Repository.DeleteByStudent(id);

    public async Task<List<TaskStudent>> FindByTask(int id) => await Repository.FindByTask(id);

    public async Task<List<TaskStudent>> FindByStudent(int id) => await Repository.FindByStudent(id);
}