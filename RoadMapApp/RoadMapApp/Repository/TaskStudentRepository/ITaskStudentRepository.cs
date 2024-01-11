using RoadMapApp.Models;
using RoadMapApp.utils.Repository;
using RoadMapApp.utils.Repository.AssociationModuleRepository;
using RoadMapApp.utils.Repository.ModuleRepository;

namespace RoadMapApp.Repository.TaskStudentRepository;

public interface ITaskStudentRepository : IAssociationModuleRepository<TaskStudent>
{
    Task<int> DeleteByTask(int id);
    Task<int> DeleteByStudent(int id);
    
    Task<List<TaskStudent>> FindByTask(int id);
    Task<List<TaskStudent>> FindByStudent(int id);
}