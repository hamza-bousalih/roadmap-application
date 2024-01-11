using RoadMapApp.Data;
using RoadMapApp.Models;
using RoadMapApp.utils.Repository;
using RoadMapApp.utils.Repository.ModuleRepository;
using Admin = RoadMapApp.Models.Admin;
namespace RoadMapApp.Repository.AdminRepository;

public class AdminRepository: ModuleRepository<Admin>, IAdminRepository
{
    public AdminRepository(DataContext context) : base(context, context.Admins)
    {
    }

    protected override void SetContextEntry(Admin item)
    {
        SetEntry(item.Roadmaps);
        
    }


    protected override IQueryable<Admin> SetIncluded()
    {
        return Table.Include(admin => admin.Roadmaps);
    }
}