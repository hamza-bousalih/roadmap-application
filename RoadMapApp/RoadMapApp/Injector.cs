using Lamar;
using RoadMapApp.Repository.OptionRepository;
using RoadMapApp.Repository.RoadmapRepository;
using RoadMapApp.Repository.SectionRepository;
using RoadMapApp.Repository.TaskRepository;
using RoadMapApp.Repository.ActionRepository;
using RoadMapApp.Repository.RoadmapStudentRepository;
using RoadMapApp.Repository.UserRepository;
using RoadMapApp.Repository.AdminRepository;
using RoadMapApp.Repository.StudentRepository;
using RoadMapApp.Repository.TaskStudentRepository;
using RoadMapApp.Services.OptionService;
using RoadMapApp.Services.ActionService;
using RoadMapApp.Services.AdminService;
using RoadMapApp.Services.RoadmapService;
using RoadMapApp.Services.RoadmapStudentService;
using RoadMapApp.Services.SectionService;
using RoadMapApp.Services.StudentService;
using RoadMapApp.Services.TaskService;
using RoadMapApp.Services.TaskStudentService;
using RoadMapApp.Services.UserService;

namespace RoadMapApp;

public static class Injector
{
    public static ServiceRegistry InjectServices(this ServiceRegistry registry)
    {
        // Inject the service here
        registry.For<IRoadmapService>().Use<RoadmapService>().Scoped();
        registry.For<ITaskService>().Use<TaskService>().Scoped();
        registry.For<IOptionService>().Use<OptionService>().Scoped();
        registry.For<IActionService>().Use<ActionService>().Scoped();
        registry.For<ISectionService>().Use<SectionService>().Scoped();
        registry.For<IAdminService>().Use<AdminService>().Scoped();
        registry.For<IStudentService>().Use<StudentService>().Scoped();
        registry.For<IUserService>().Use<UserService>().Scoped();

        registry.For<IRoadmapStudentService>().Use<RoadmapStudentService>().Scoped();
        registry.For<ITaskStudentService>().Use<TaskStudentService>().Scoped();

        return registry;
    }

    public static ServiceRegistry InjectRepositories(this ServiceRegistry registry)
    {
        // Inject the repositories here
        registry.For<IRoadmapRepository>().Use<RoadmapRepository>().Transient();
        registry.For<ITaskRepository>().Use<TaskRepository>().Transient();
        registry.For<ITaskRepository>().Use<TaskRepository>().Transient();
        registry.For<IOptionRepository>().Use<OptionRepository>().Transient();
        registry.For<IActionRepository>().Use<ActionRepository>().Transient();
        registry.For<ISectionRepository>().Use<SectionRepository>().Transient();
        registry.For<IAdminRepository>().Use<AdminRepository>().Transient();
        registry.For<IStudentRepository>().Use<StudentRepository>().Transient();
        registry.For<IUserRepository>().Use<UserRepository>().Transient();

        registry.For<IRoadmapStudentRepository>().Use<RoadmapStudentRepository>().Transient();
        registry.For<ITaskStudentRepository>().Use<TaskStudentRepository>().Transient();

        return registry;
    }
}