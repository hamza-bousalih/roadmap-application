using RoadMapApp.Models;
using RoadMapApp.utils.Repository;
using RoadMapApp.utils.Repository.ModuleRepository;


namespace RoadMapApp.Repository.UserRepository;

public interface IUserRepository: IModuleRepository<User>
{
}