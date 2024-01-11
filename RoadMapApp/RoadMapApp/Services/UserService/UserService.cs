using Lamar;
using RoadMapApp.Models;

using RoadMapApp.Repository.UserRepository;
using RoadMapApp.utils.service;
using RoadMapApp.utils.service.ModuleService;


namespace RoadMapApp.Services.UserService;

public class UserService: ModuleService<User, IUserRepository>, IUserService
{
    public UserService(IContainer container): base(container)
    {
    }
}