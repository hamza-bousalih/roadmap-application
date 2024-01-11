using AutoMapper;
using RoadMapApp.Controllers.Dto;
using RoadMapApp.Models;
using RoadMapApp.Models.Enums;
using Action = RoadMapApp.Models.Action;
using Task = RoadMapApp.Models.Task;
using TaskStatus = RoadMapApp.Models.Enums.TaskStatus;

namespace RoadMapApp;

public class AutoMapperProfile : Profile
{
    public AutoMapperProfile()
    {
        RoadmapMapper();
        SectionMapper();
        OptionMapper();
        ActionMapper();
        TaskMapper();
        
        UserMapper();
        AdminMapper();
        StudentMapper();
        
        RoadmapStudentMapper();
        ActionStudentMapper();
        TaskStudentMapper();
        ChoiceMapper();
    }
    
    private void RoadmapMapper()
    {
        CreateMap<RoadmapDto, Roadmap>()
            .ForMember(dest => dest.Admin, opt => opt.MapFrom(src => src.Admin))
            .ForMember(dest => dest.Start, opt => opt.MapFrom(src => src.Start))
            .ForMember(dest => dest.RoadmapStudents, opt => opt.MapFrom(src => src.RoadmapStudents));
        CreateMap<Roadmap, RoadmapDto>()
            .ForMember(dest => dest.Admin, opt => opt.MapFrom(src => src.Admin))
            .ForMember(dest => dest.Start, opt => opt.MapFrom(src => src.Start))
            .ForMember(dest => dest.RoadmapStudents, opt => opt.MapFrom(src => src.RoadmapStudents));
    }

    private void SectionMapper()
    {
        CreateMap<SectionDto, Section>()
            .ForMember(dest => dest.Next, opt => opt.MapFrom(src => src.Next))
            .ForMember(dest => dest.Options, opt => opt.MapFrom(src => src.Options));
        CreateMap<Section, SectionDto>()
            .ForMember(dest => dest.Next, opt => opt.MapFrom(src => src.Next))
            .ForMember(dest => dest.Options, opt => opt.MapFrom(src => src.Options));
    }

    private void OptionMapper()
    {
        CreateMap<OptionDto, Option>()
            .ForMember(dest => dest.Section, opt => opt.MapFrom(src => src.Section))
            .ForMember(dest => dest.Start, opt => opt.MapFrom(src => src.Start))
            .ForMember(dest => dest.Choices, opt => opt.MapFrom(src => src.Choices));
        CreateMap<Option, OptionDto>()
            .ForMember(dest => dest.Section, opt => opt.MapFrom(src => src.Section))
            .ForMember(dest => dest.Start, opt => opt.MapFrom(src => src.Start))
            .ForMember(dest => dest.Choices, opt => opt.MapFrom(src => src.Choices));
    }

    private void ActionMapper()
    {
        CreateMap<ActionDto, Action>()
            .ForMember(dest => dest.Next, opt => opt.MapFrom(src=>src.Next))
            .ForMember(dest => dest.Tasks, opt => opt.MapFrom(src=>src.Tasks))
            .ForMember(dest => dest.ActionStudents, opt => opt.MapFrom(src=>src.ActionStudents));
        CreateMap<Action, ActionDto>()
            .ForMember(dest => dest.Next, opt => opt.MapFrom(src=>src.Next))
            .ForMember(dest => dest.Tasks, opt => opt.MapFrom(src=>src.Tasks))
            .ForMember(dest => dest.ActionStudents, opt => opt.MapFrom(src=>src.ActionStudents));
    }
    
    private void TaskMapper()
    {
        CreateMap<TaskDto, Task>()
            .ForMember(dest => dest.Action, opt => opt.MapFrom(src => src.Action))
            .ForMember(dest => dest.Type, opt => opt.MapFrom(src => Enum.Parse(typeof(TaskType), src.Type)));
        
        CreateMap<Task, TaskDto>()
            .ForMember(dest => dest.Action, opt => opt.MapFrom(src => src.Action))
            .ForMember(dest => dest.Type, opt => opt.MapFrom(src => src.Type.ToString()));
    }
    
    
    // Role Classes
    private void UserMapper()
    {
        CreateMap<UserDto, User>();
        CreateMap<User, UserDto>();
    }
    
    private void AdminMapper()
    {
        CreateMap<AdminDto, Admin>()
            .ForMember(dest => dest.Roadmaps, opt => opt.MapFrom(src => src.Roadmaps));
        CreateMap<Admin, AdminDto>()
            .ForMember(dest => dest.Roadmaps, opt => opt.MapFrom(src => src.Roadmaps));
    }
    
    private void StudentMapper()
    {
        CreateMap<StudentDto, Student>()
            .ForMember(dest => dest.Choices, opt => opt.MapFrom(src => src.Choices))
            .ForMember(dest => dest.ActionStudents, opt => opt.MapFrom(src => src.ActionStudents))
            .ForMember(dest => dest.RoadmapStudents, opt => opt.MapFrom(src => src.RoadmapStudents));
        
        CreateMap<Student, StudentDto>()
            .ForMember(dest => dest.Choices, opt => opt.MapFrom(src => src.Choices))
            .ForMember(dest => dest.ActionStudents, opt => opt.MapFrom(src => src.ActionStudents))
            .ForMember(dest => dest.RoadmapStudents, opt => opt.MapFrom(src => src.RoadmapStudents));
    }
    
    
    // Associations Classes 
    private void RoadmapStudentMapper()
    {
        CreateMap<RoadmapStudentDto, RoadmapStudent>()
            .ForMember(dest => dest.Roadmap, opt => opt.MapFrom(src => src.Roadmap))
            .ForMember(dest => dest.Student, opt => opt.MapFrom(src => src.Student))
            .ForMember(dest => dest.StudentId, opt => opt.MapFrom(src => src.Student.Id))
            .ForMember(dest => dest.RoadmapId, opt => opt.MapFrom(src => src.Roadmap.Id))
            .ForMember(dest => dest.Status, opt => opt.MapFrom(src => Enum.Parse(typeof(RoadmapStatus), src.Status)));
        
        CreateMap<RoadmapStudent, RoadmapStudentDto>()
            .ForMember(dest => dest.Roadmap, opt => opt.MapFrom(src => src.Roadmap))
            .ForMember(dest => dest.Student, opt => opt.MapFrom(src => src.Student))
            .ForMember(dest => dest.Status, opt => opt.MapFrom(src => src.Status.ToString()));
    }
    
    private void ActionStudentMapper()
    {
        CreateMap<ActionStudentDto, ActionStudent>()
            .ForMember(dest => dest.Action, opt => opt.MapFrom(src => src.Action))
            .ForMember(dest => dest.Student, opt => opt.MapFrom(src => src.Student))
            .ForMember(dest => dest.StudentId, opt => opt.MapFrom(src => src.Student.Id))
            .ForMember(dest => dest.ActionId, opt => opt.MapFrom(src => src.Action.Id))
            .ForMember(dest => dest.Status, opt => opt.MapFrom(src => Enum.Parse(typeof(ActionStatus), src.Status)));
        
        CreateMap<ActionStudent, ActionStudentDto>()
            .ForMember(dest => dest.Action, opt => opt.MapFrom(src => src.Action))
            .ForMember(dest => dest.Student, opt => opt.MapFrom(src => src.Student))
            .ForMember(dest => dest.Status, opt => opt.MapFrom(src => src.Status.ToString()));
    }
    
    private void TaskStudentMapper()
    {
        CreateMap<TaskStudentDto, TaskStudent>()
            .ForMember(dest => dest.Task, opt => opt.MapFrom(src => src.Task))
            .ForMember(dest => dest.Student, opt => opt.MapFrom(src => src.Student))
            .ForMember(dest => dest.StudentId, opt => opt.MapFrom(src => src.Student.Id))
            .ForMember(dest => dest.TaskId, opt => opt.MapFrom(src => src.Task.Id))
            .ForMember(dest => dest.Status, opt => opt.MapFrom(src => Enum.Parse(typeof(TaskStatus), src.Status)));
        
        CreateMap<TaskStudent, TaskStudentDto>()
            .ForMember(dest => dest.Task, opt => opt.MapFrom(src => src.Task))
            .ForMember(dest => dest.Student, opt => opt.MapFrom(src => src.Student))
            .ForMember(dest => dest.Status, opt => opt.MapFrom(src => src.Status.ToString()));
    }
    
    private void ChoiceMapper()
    {
        CreateMap<ChoiceDto, Choice>()
            .ForMember(dest => dest.Option, opt => opt.MapFrom(src => src.Option))
            .ForMember(dest => dest.Student, opt => opt.MapFrom(src => src.Student))
            .ForMember(dest => dest.OptionId, opt => opt.MapFrom(src => src.Option.Id))
            .ForMember(dest => dest.StudentId, opt => opt.MapFrom(src => src.Student.Id));
        
        CreateMap<Choice, ChoiceDto>()
            .ForMember(dest => dest.Option, opt => opt.MapFrom(src => src.Option))
            .ForMember(dest => dest.Student, opt => opt.MapFrom(src => src.Student));
    }
}
