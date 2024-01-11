using AutoMapper;
using Lamar;
using Microsoft.AspNetCore.Mvc;
using RoadMapApp.Controllers.Dto;
using RoadMapApp.Models;
using RoadMapApp.Services.SectionService;
using RoadMapApp.utils.controller;

namespace RoadMapApp.Controllers.RestApi;

[ApiController]
[Route("api/section")]
public class SectionApi : ModuleController<Section, SectionDto, ISectionService>
{
    public SectionApi(IContainer container, IMapper mapper):
        base(container, mapper)
    {
    }
        
    [HttpGet("{id:int}")]
    public override Task<ActionResult<SectionDto>> GetById(int id) => base.GetById(id);

    [HttpGet]
    public override Task<ActionResult<List<SectionDto>>> GetAll() => base.GetAll();

    [HttpPost]
    public override Task<ActionResult<SectionDto>> Create(SectionDto dto) => base.Create(dto);

    [HttpGet("optimized")]
    public override Task<ActionResult<List<SectionDto>>> Optimized() => base.Optimized();

    [HttpPost("all")]
    public override Task<ActionResult<List<SectionDto>>> Create(List<SectionDto> dtos) => base.Create(dtos);

    [HttpPut]
    public override Task<ActionResult<SectionDto>> Update(SectionDto dto) => base.Update(dto);

    [HttpPut("all")]
    public override Task<ActionResult<List<SectionDto>>> Update(List<SectionDto> dtos) => base.Update(dtos);

    [HttpDelete("{id:int}")]
    public override Task<ActionResult<int>> Delete(int id) => base.Delete(id);

    [HttpDelete]
    public override Task<ActionResult<int>> Delete(SectionDto dto) => base.Delete(dto);

    [HttpDelete("all")]
    public override Task<ActionResult<int>> Delete(List<SectionDto> dtos) => base.Delete(dtos);

    [HttpPut("update-create")]
    public override Task<ActionResult<SectionDto>> UpdateOrCreate(SectionDto dto) => base.UpdateOrCreate(dto);

    [HttpPut("update-create/all")]
    public override Task<ActionResult<List<SectionDto>>> UpdateOrCreate(List<SectionDto> dtos) => base.UpdateOrCreate(dtos);
}