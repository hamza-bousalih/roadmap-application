using RoadMapApp.Data;
using RoadMapApp.Models;
using RoadMapApp.utils.Repository;
using RoadMapApp.utils.Repository.ModuleRepository;
using Student = RoadMapApp.Models.Student;
namespace RoadMapApp.Repository.StudentRepository;

public class StudentRepository: ModuleRepository<Student>, IStudentRepository
{
    public StudentRepository(DataContext context) : base(context, context.Students)
    {
    }

    protected override void SetContextEntry(Student item)
    {
        //SetEntry(item.Choices);
        
    }


    protected override IQueryable<Student> SetIncluded()
    {
        return Table
            .Include(Student => Student.Choices)
            .Include(Student => Student.ActionStudents)
            .Include(Student => Student.RoadmapStudents)
            
            
            ;
    }
}