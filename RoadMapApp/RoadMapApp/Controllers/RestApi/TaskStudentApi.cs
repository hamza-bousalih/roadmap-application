using AutoMapper;
using Lamar;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using RoadMapApp.Controllers.Dto;
using RoadMapApp.Models;
using RoadMapApp.Services.TaskStudentService;
using RoadMapApp.utils.controller;

namespace RoadMapApp.Controllers.RestApi;

[DisableCors]
[ApiController]
[Route("api/taskstudent")]
public class TaskStudentApi : AssociationModuleController<TaskStudent, TaskStudentDto, ITaskStudentService>
{
    public TaskStudentApi(IContainer container, IMapper mapper) :
        base(container, mapper)
    {
    }

    [HttpGet]
    public override Task<ActionResult<List<TaskStudentDto>>> GetAll() => base.GetAll();

    [HttpPost]
    public override Task<ActionResult<TaskStudentDto>> Create(TaskStudentDto dto) =>
        base.Create(dto);

    [HttpGet("optimized")]
    public override Task<ActionResult<List<TaskStudentDto>>> Optimized() => base.Optimized();

    [HttpPost("all")]
    public override Task<ActionResult<List<TaskStudentDto>>>
        Create(List<TaskStudentDto> dtos) =>
        base.Create(dtos);

    [HttpPut]
    public override Task<ActionResult<TaskStudentDto>> Update(TaskStudentDto dto) =>
        base.Update(dto);

    [HttpPut("all")]
    public override Task<ActionResult<List<TaskStudentDto>>>
        Update(List<TaskStudentDto> dtos) =>
        base.Update(dtos);

    // Mark As POST accept the body
    [HttpPost("id")]
    public override async Task<ActionResult<TaskStudentDto>> FindByIds(TaskStudentDto dto) =>
        await base.FindByIds(dto);

    [HttpDelete]
    public override async Task<ActionResult<int>> Delete(TaskStudentDto dto) => Ok(await base.Delete(dto));

    [HttpDelete("all")]
    public override async Task<ActionResult<int>> Delete(List<TaskStudentDto> dtos) => Ok(await base.Delete(dtos));

    //--- COSTUME APIs --------------------------------------------------------------------
    
    [HttpGet("student/{id:int}")]
    public async Task<ActionResult<List<TaskStudentDto>>> FindByStudent(int id) =>
        await FetchListAsync(id, Service.FindByStudent);

    [HttpDelete("student/{id:int}")]
    public async Task<ActionResult<int>> DeleteByStudent(int id) =>
        await DeleteAsync(id, Service.DeleteByStudent);

    [HttpGet("roadmap/{id:int}")]
    public async Task<ActionResult<List<TaskStudentDto>>> FindByRoadmap(int id) =>
        await FetchListAsync(id, Service.FindByTask);

    [HttpDelete("roadmap/{id:int}")]
    public async Task<ActionResult<int>> DeleteByRoadmap(int id) =>
        await DeleteAsync(id, Service.DeleteByTask);
}