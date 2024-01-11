using RoadMapApp.Models;
using RoadMapApp.utils.service.AssociationService;

namespace RoadMapApp.Services.TaskStudentService;

public interface ITaskStudentService: IAssociationService<TaskStudent>
{
    Task<int> DeleteByTask(int id);
    Task<int> DeleteByStudent(int id);
    
    Task<List<TaskStudent>> FindByTask(int id);
    Task<List<TaskStudent>> FindByStudent(int id);
}