using RoadMapApp.utils.Repository;
using RoadMapApp.utils.Repository.ModuleRepository;
using Student = RoadMapApp.Models.Student;

namespace RoadMapApp.Repository.StudentRepository;

public interface IStudentRepository: IModuleRepository<Student>
{
}