using RoadMapApp.Models;
using RoadMapApp.utils.Repository;
using RoadMapApp.utils.Repository.AssociationModuleRepository;
using RoadMapApp.utils.Repository.ModuleRepository;

namespace RoadMapApp.Repository.RoadmapStudentRepository;

public interface IRoadmapStudentRepository : IAssociationModuleRepository<RoadmapStudent>
{
    Task<int> DeleteByRoadmap(int id);
    Task<int> DeleteByStudent(int id);
    
    Task<List<RoadmapStudent>> FindByRoadmap(int id);
    Task<List<RoadmapStudent>> FindByStudent(int id);
}