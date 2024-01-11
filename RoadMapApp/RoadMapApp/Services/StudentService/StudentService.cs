using Lamar;
using RoadMapApp.Repository.StudentRepository;
using RoadMapApp.utils.service;
using RoadMapApp.utils.service.ModuleService;
using Student = RoadMapApp.Models.Student;

namespace RoadMapApp.Services.StudentService;

public class StudentService: ModuleService<Student, IStudentRepository>, IStudentService
{
    public StudentService(IContainer container): base(container)
    {
    }
}