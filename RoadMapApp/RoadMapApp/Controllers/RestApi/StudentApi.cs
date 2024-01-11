using AutoMapper;
using Lamar;
using Microsoft.AspNetCore.Mvc;
using RoadMapApp.Controllers.Dto;
using RoadMapApp.Models;
using RoadMapApp.Services.StudentService;
using RoadMapApp.utils.controller;

namespace RoadMapApp.Controllers.RestApi;

[ApiController]
[Route("api/student")]
public class StudentApi : ModuleController<Student, StudentDto, IStudentService>
{
    public StudentApi(IContainer container, IMapper mapper):
        base(container, mapper)
    {
    }
        
    [HttpGet("{id:int}")]
    public override Task <ActionResult<StudentDto>> GetById(int id) => base.GetById(id);

    [HttpGet]
    public override Task <ActionResult<List<StudentDto>>> GetAll() => base.GetAll();

    [HttpPost]
    public override Task<ActionResult<StudentDto>> Create(StudentDto dto) => base.Create(dto);

    [HttpGet("optimized")]
    public override Task<ActionResult<List<StudentDto>>> Optimized() => base.Optimized();

    [HttpPost("all")]
    public override Task<ActionResult<List<StudentDto>>> Create(List<StudentDto> dtos) => base.Create(dtos);

    [HttpPut]
    public override Task<ActionResult<StudentDto>> Update(StudentDto dto) => base.Update(dto);

    [HttpPut("all")]
    public override Task<ActionResult<List<StudentDto>>> Update(List<StudentDto> dtos) => base.Update(dtos);

    [HttpDelete("{id:int}")]
    public override Task<ActionResult<int>> Delete(int id) => base.Delete(id);

    [HttpDelete]
    public override Task<ActionResult<int>> Delete(StudentDto dto) => base.Delete(dto);

    [HttpDelete("all")]
    public override Task<ActionResult<int>> Delete(List<StudentDto> dtos) => base.Delete(dtos);

    [HttpPut("update-create")]
    public override Task<ActionResult<StudentDto>> UpdateOrCreate(StudentDto dto) => base.UpdateOrCreate(dto);

    [HttpPut("update-create/all")]
    public override Task<ActionResult<List<StudentDto>>> UpdateOrCreate(List<StudentDto> dtos) => base.UpdateOrCreate(dtos);
}