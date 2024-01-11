using RoadMapApp.Models;
using RoadMapApp.utils.service.AssociationService;
using RoadMapApp.utils.service.ModuleService;

namespace RoadMapApp.Services.RoadmapStudentService;

public interface IRoadmapStudentService: IAssociationService<RoadmapStudent>
{
    Task<int> DeleteByRoadmap(int id);
    Task<int> DeleteByStudent(int id);
    
    Task<List<RoadmapStudent>> FindByRoadmap(int id);
    Task<List<RoadmapStudent>> FindByStudent(int id);
}