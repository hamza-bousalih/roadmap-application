using AutoMapper;
using Lamar;
using Microsoft.AspNetCore.Mvc;
using RoadMapApp.Controllers.Dto;
using RoadMapApp.Services.TaskService;
using RoadMapApp.utils.controller;
using Task = RoadMapApp.Models.Task;

namespace RoadMapApp.Controllers.RestApi;

[ApiController]
[Route("api/task")]
public class TaskApi : ModuleController<Task, TaskDto, ITaskService>
{
    public TaskApi(IContainer container, IMapper mapper):
        base(container, mapper)
    {
    }

    [HttpGet("{id:int}")]
    public override Task<ActionResult<TaskDto>> GetById(int id) => base.GetById(id);

    [HttpGet]
    public override Task<ActionResult<List<TaskDto>>> GetAll() => base.GetAll();

    [HttpPost]
    public override Task<ActionResult<TaskDto>> Create(TaskDto dto) => base.Create(dto);

    [HttpGet("optimized")]
    public override Task<ActionResult<List<TaskDto>>> Optimized() => base.Optimized();

    [HttpPost("all")]
    public override Task<ActionResult<List<TaskDto>>> Create(List<TaskDto> dtos) => base.Create(dtos);

    [HttpPut]
    public override Task<ActionResult<TaskDto>> Update(TaskDto dto) => base.Update(dto);

    [HttpPut("all")]
    public override Task<ActionResult<List<TaskDto>>> Update(List<TaskDto> dtos) => base.Update(dtos);

    [HttpDelete("{id:int}")]
    public override Task<ActionResult<int>> Delete(int id) => base.Delete(id);

    [HttpDelete]
    public override Task<ActionResult<int>> Delete(TaskDto dto) => base.Delete(dto);

    [HttpDelete("all")]
    public override Task<ActionResult<int>> Delete(List<TaskDto> dtos) => base.Delete(dtos);

    [HttpPut("update-create")]
    public override Task<ActionResult<TaskDto>> UpdateOrCreate(TaskDto dto) => base.UpdateOrCreate(dto);

    [HttpPut("update-create/all")]
    public override Task<ActionResult<List<TaskDto>>> UpdateOrCreate(List<TaskDto> dtos) => base.UpdateOrCreate(dtos);
}