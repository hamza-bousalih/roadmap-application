using Lamar;
using RoadMapApp.Models;
using RoadMapApp.Repository.RoadmapStudentRepository;
using RoadMapApp.utils.service.AssociationService;

namespace RoadMapApp.Services.RoadmapStudentService;

public class RoadmapStudentService : AssociationService<RoadmapStudent, IRoadmapStudentRepository>, IRoadmapStudentService
{
    public RoadmapStudentService(IContainer container): base(container)
    {
    }

    public async Task<int> DeleteByRoadmap(int id) => await Repository.DeleteByRoadmap(id);

    public async Task<int> DeleteByStudent(int id) => await Repository.DeleteByStudent(id);

    public async Task<List<RoadmapStudent>> FindByRoadmap(int id) => await Repository.FindByRoadmap(id);

    public async Task<List<RoadmapStudent>> FindByStudent(int id) => await Repository.FindByStudent(id);
}