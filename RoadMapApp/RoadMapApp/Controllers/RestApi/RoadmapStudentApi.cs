using AutoMapper;
using Lamar;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using RoadMapApp.Models;
using RoadMapApp.Controllers.Dto;
using RoadMapApp.Services.RoadmapStudentService;
using RoadMapApp.utils.controller;

namespace RoadMapApp.Controllers.RestApi;

[DisableCors]
[ApiController]
[Route("api/roadmapstudent")]
public class RoadmapStudentApi : AssociationModuleController<RoadmapStudent, RoadmapStudentDto, IRoadmapStudentService>
{
    public RoadmapStudentApi(IContainer container, IMapper mapper) :
        base(container, mapper)
    {
    }

    [HttpGet]
    public override Task<ActionResult<List<RoadmapStudentDto>>> GetAll() => 
        base.GetAll();

    [HttpPost]
    public override Task<ActionResult<RoadmapStudentDto>> Create(RoadmapStudentDto dto) => 
        base.Create(dto);

    [HttpGet("optimized")]
    public override Task<ActionResult<List<RoadmapStudentDto>>> Optimized() =>
        base.Optimized();

    [HttpPost("all")]
    public override Task<ActionResult<List<RoadmapStudentDto>>> Create(List<RoadmapStudentDto> dtos) =>
        base.Create(dtos);

    [HttpPut]
    public override Task<ActionResult<RoadmapStudentDto>> Update(RoadmapStudentDto dto) => 
        base.Update(dto);

    [HttpPut("all")]
    public override Task<ActionResult<List<RoadmapStudentDto>>> Update(List<RoadmapStudentDto> dtos) =>
        base.Update(dtos);

    // Mark As POST accept the body
    [HttpPost("id")]
    public override async Task<ActionResult<RoadmapStudentDto>> FindByIds(RoadmapStudentDto dto) =>
        await base.FindByIds(dto);

    [HttpDelete]
    public override async Task<ActionResult<int>> Delete(RoadmapStudentDto dto) => 
        await base.Delete(dto);

    [HttpDelete("all")]
    public override async Task<ActionResult<int>> Delete(List<RoadmapStudentDto> dtos) =>
        await base.Delete(dtos);

    //--- COSTUME APIs --------------------------------------------------------------------

    [HttpDelete("student/{id:int}")]
    public async Task<ActionResult<int>> DeleteByStudent(int id) =>
        await DeleteAsync(id, Service.DeleteByStudent);

    [HttpGet("student/{id:int}")]
    public async Task<ActionResult<List<RoadmapStudentDto>>> FindByStudent(int id) =>
        await FetchListAsync(id, Service.FindByStudent);

    [HttpDelete("roadmap/{id:int}")]
    public async Task<ActionResult<int>> DeleteByRoadmap(int id) =>
        await DeleteAsync(id, Service.DeleteByRoadmap);

    [HttpGet("roadmap/{id:int}")]
    public async Task<ActionResult<List<RoadmapStudentDto>>> FindByRoadmap(int id) =>
        await FetchListAsync(id, Service.FindByRoadmap);
}