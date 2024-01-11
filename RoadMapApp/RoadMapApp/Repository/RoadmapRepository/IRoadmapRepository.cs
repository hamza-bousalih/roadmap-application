using RoadMapApp.Models;
using RoadMapApp.utils.Repository;
using RoadMapApp.utils.Repository.ModuleRepository;

namespace RoadMapApp.Repository.RoadmapRepository;

public interface IRoadmapRepository : IModuleRepository<Roadmap>
{
    public Task<List<Roadmap>> FindAllByAdmin(int id);
    public Task<List<Roadmap>> FindAllByStudent(int id);
    public Task<Roadmap> FindByAdmin(int id);
    public Task<Roadmap> FindByStudent(int id);
    public Task<Roadmap> FindByIdAndStudentId(int id, int studentId);
}