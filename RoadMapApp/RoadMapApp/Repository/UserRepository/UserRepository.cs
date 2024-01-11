using RoadMapApp.Data;
using RoadMapApp.Models;
using RoadMapApp.utils.Repository;
using RoadMapApp.utils.Repository.ModuleRepository;


namespace RoadMapApp.Repository.UserRepository;

public class UserRepository: ModuleRepository<User>, IUserRepository
{
    public UserRepository(DataContext context) : base(context, context.Users)
    {
    }


    protected override IQueryable<User> SetIncluded()
    {
        return Table;
    }
}