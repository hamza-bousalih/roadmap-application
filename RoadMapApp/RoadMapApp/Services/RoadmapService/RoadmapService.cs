using Lamar;
using RoadMapApp.utils.service;
using RoadMapApp.Models;
using RoadMapApp.Repository;
using RoadMapApp.Repository.RoadmapRepository;
using RoadMapApp.utils.service.ModuleService;

namespace RoadMapApp.Services.RoadmapService
{
    public class RoadmapService : ModuleService<Roadmap, IRoadmapRepository>, IRoadmapService
    {
        public RoadmapService(IContainer container): base(container)
        {
        }

        public async Task<List<Roadmap>> FindAllByAdmin(int id)
        {
            return await Repository.FindAllByAdmin(id);
        }

        public async Task<List<Roadmap>> FindAllByStudent(int id)
        {
            return await Repository.FindAllByStudent(id);
        }

        public async Task<Roadmap> FindByAdmin(int id)
        {
            return await Repository.FindByAdmin(id);
        }

        public async Task<Roadmap> FindByStudent(int id)
        {
            return await Repository.FindByStudent(id);
        }

        public async Task<Roadmap> FindByIdAndStudentId(int id, int studentId)
        {
            return await Repository.FindByIdAndStudentId(id, studentId);
        }
    }
}