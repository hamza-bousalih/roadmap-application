using RoadMapApp.utils.service;
using RoadMapApp.Models;
using RoadMapApp.utils.service.ModuleService;

namespace RoadMapApp.Services.RoadmapService;

public interface IRoadmapService: IModuleService<Roadmap>
{
    public Task<List<Roadmap>> FindAllByAdmin(int id);
    public Task<List<Roadmap>> FindAllByStudent(int id);
    public Task<Roadmap> FindByAdmin(int id);
    public Task<Roadmap> FindByStudent(int id);
    Task<Roadmap> FindByIdAndStudentId(int id, int studentId);
    Task <List<Roadmap>> Search(string query);
}