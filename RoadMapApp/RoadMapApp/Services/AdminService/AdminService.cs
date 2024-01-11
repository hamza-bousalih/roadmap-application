using Lamar;
using RoadMapApp.Repository.AdminRepository;
using RoadMapApp.utils.service;
using RoadMapApp.utils.service.ModuleService;
using Admin = RoadMapApp.Models.Admin;

namespace RoadMapApp.Services.AdminService;

public class AdminService: ModuleService<Admin, IAdminRepository>, IAdminService
{
    public AdminService(IContainer container): base(container)
    {
    }
}