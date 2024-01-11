using RoadMapApp.Models;
using RoadMapApp.utils.Repository;
using RoadMapApp.utils.Repository.ModuleRepository;

namespace RoadMapApp.Repository.AdminRepository;

public interface IAdminRepository: IModuleRepository<Admin>
{
}