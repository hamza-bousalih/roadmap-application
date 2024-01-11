using RoadMapApp.Data;
using RoadMapApp.Models;
using RoadMapApp.utils.Repository.AssociationModuleRepository;

namespace RoadMapApp.Repository.RoadmapStudentRepository;

public class RoadmapStudentRepository : AssociationModuleRepository<RoadmapStudent>, IRoadmapStudentRepository
{
    public RoadmapStudentRepository(DataContext context) : base(context, context.RoadmapStudents)
    {
    }

    protected override void SetContextEntry(RoadmapStudent item)
    {
        SetEntry(item.Roadmap);
        SetEntry(item.Student);
    }

    protected override IQueryable<RoadmapStudent> SetIncluded()
    {
        return Table
            .Include(rs => rs.Roadmap)
            .Include(rs => rs.Student);
    }

    public async Task<int> DeleteByRoadmap(int id) => await Delete(i => i.RoadmapId == id);

    public async Task<int> DeleteByStudent(int id) => await Delete(i => i.StudentId == id);
    
    public async Task<List<RoadmapStudent>> FindByRoadmap(int id) => await Filter(rs => rs.RoadmapId == id);

    public async Task<List<RoadmapStudent>> FindByStudent(int id) => await Filter(rs => rs.StudentId == id);
}