using RoadMapApp.Data;
using RoadMapApp.Models;
using RoadMapApp.utils.Repository.ModuleRepository;

namespace RoadMapApp.Repository.RoadmapRepository;

public class RoadmapRepository : ModuleRepository<Roadmap>, IRoadmapRepository
{
    public RoadmapRepository(DataContext context) : base(context, context.Roadmaps)
    {
    }

    protected override void SetContextEntry(Roadmap item)
    {
        SetEntry(item.Admin);
        SetEntry(item.Start);
    }

    protected override IQueryable<Roadmap> SetIncluded()
    {
        return Table
                .Include(r => r.Start)
                .ThenInclude(s => s.Options)
                .ThenInclude(o => o.Start)
                .ThenInclude(a => a.Tasks)
                .Include(r => r.Admin)
                .Include(r => r.RoadmapStudents)
                .ThenInclude(rs => rs.Student);
    }

    protected override void FetchNexts(Roadmap roadmap)
    {
        if (roadmap == null) return;
        IncludeNext(roadmap.Start);
        
        var nextSection = roadmap.Start;
        while (nextSection is not null)
        {
            Context.Entry(nextSection).Collection(n => n.Options).Load();
            
            foreach (var option in nextSection.Options)
            {
                if (option.Start == null)
                    Context.Entry(option).Reference(op => op.Start).Load();
                IncludeNext(option.Start);
            }
            nextSection = nextSection.Next;
        }
    }

    // Costume operations
    public async Task<List<Roadmap>> FindAllByAdmin(int id) =>
        await Filter(r => r.Admin.Id == id);

    public async Task<List<Roadmap>> FindAllByStudent(int id) =>
        await Filter(r => r.RoadmapStudents.Any(rs => rs.StudentId == id));

    public async Task<Roadmap> FindByAdmin(int id) =>
        await IncludedTable.FirstOrDefaultAsync(r => r.Admin.Id == id);

    public async Task<Roadmap> FindByStudent(int id) =>
        await IncludedTable.FirstOrDefaultAsync(r => r.RoadmapStudents.Any(rs => rs.StudentId == id));

    public async Task<Roadmap> FindByIdAndStudentId(int id, int studentId) =>
        await IncludedTable.FirstOrDefaultAsync(r =>
            r.RoadmapStudents.Any(rs => rs.RoadmapId == id && rs.StudentId == studentId)
        );
    public async Task<List<Roadmap>> Search(string query)=>
   
        await Filter(r => r.Title == query);

}