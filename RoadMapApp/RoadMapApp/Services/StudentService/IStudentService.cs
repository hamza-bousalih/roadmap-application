using RoadMapApp.utils.service;
using RoadMapApp.utils.service.ModuleService;
using Student = RoadMapApp.Models.Student;

namespace RoadMapApp.Services.StudentService;

public interface IStudentService: IModuleService<Student>
{

}