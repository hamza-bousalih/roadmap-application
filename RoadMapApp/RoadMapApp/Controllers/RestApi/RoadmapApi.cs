using AutoMapper;
using Lamar;
using Microsoft.AspNetCore.Mvc;
using RoadMapApp.Models;
using RoadMapApp.Controllers.Dto;
using RoadMapApp.Services.RoadmapService;
using RoadMapApp.utils.controller;

namespace RoadMapApp.Controllers.RestApi;

[ApiController]
[Route("api/roadmap")]
public class RoadmapApi : ModuleController<Roadmap, RoadmapDto, IRoadmapService>
{
    public RoadmapApi(IContainer container, IMapper mapper):
        base(container, mapper)
    {
    }

    [HttpGet("{id:int}")]
    public override Task<ActionResult<RoadmapDto>> GetById(int id) => base.GetById(id);

    [HttpGet]
    public override Task<ActionResult<List<RoadmapDto>>> GetAll() => base.GetAll();

    [HttpPost]
    public override Task<ActionResult<RoadmapDto>> Create(RoadmapDto dto) => base.Create(dto);

    [HttpGet("optimized")]
    public override Task<ActionResult<List<RoadmapDto>>> Optimized() => base.Optimized();

    [HttpPost("all")]
    public override Task<ActionResult<List<RoadmapDto>>> Create(List<RoadmapDto> dtos) => base.Create(dtos);

    [HttpPut]
    public override Task<ActionResult<RoadmapDto>> Update(RoadmapDto dto) => base.Update(dto);

    [HttpPut("all")]
    public override Task<ActionResult<List<RoadmapDto>>> Update(List<RoadmapDto> dtos) => base.Update(dtos);

    [HttpDelete("{id:int}")]
    public override Task<ActionResult<int>> Delete(int id) => base.Delete(id);

    [HttpDelete]
    public override Task<ActionResult<int>> Delete(RoadmapDto dto) => base.Delete(dto);

    [HttpDelete("all")]
    public override Task<ActionResult<int>> Delete(List<RoadmapDto> dtos) => base.Delete(dtos);

    [HttpPut("update-create")]
    public override Task<ActionResult<RoadmapDto>> UpdateOrCreate(RoadmapDto dto) => base.UpdateOrCreate(dto);

    [HttpPut("update-create/all")]
    public override Task<ActionResult<List<RoadmapDto>>> UpdateOrCreate(List<RoadmapDto> dtos) => base.UpdateOrCreate(dtos);

    // Costume Apis
    [HttpGet("admin/{id:int}/all")]
    public async Task<ActionResult<List<RoadmapDto>>> FindAllByAdmin(int id)
    {
        var result = ToDto(await Service.FindAllByAdmin(id));
        return Ok(result) ;
    }
        
    [HttpGet("student/{id:int}/all")]
    public async Task<ActionResult<List<RoadmapDto>>> FindAllByStudent(int id)
    {
        var result = ToDto(await Service.FindAllByStudent(id));
        return Ok(result) ;
    }
        
    // [HttpGet("admin/{id:int}")]
    // public async Task<ActionResult<RoadmapDto>> FindByAdmin(int id)
    // {
    //     var result = ToDto(await Service.FindByAdmin(id));
    //     return Ok(result) ;
    // }

    [HttpGet("student/{id:int}")]
    public async Task<ActionResult<RoadmapDto>> FindByStudent(int id) => 
        await FetchAsync(id, Service.FindByStudent);

    [HttpGet("{id:int}/student/{studentId:int}")]
    public async Task<ActionResult<RoadmapDto>> FindByIdAndStudentId(int id, int studentId) => 
        await FetchAsync(id, studentId, Service.FindByIdAndStudentId);
}