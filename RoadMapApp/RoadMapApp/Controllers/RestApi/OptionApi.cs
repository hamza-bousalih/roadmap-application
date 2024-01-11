using AutoMapper;
using Lamar;
using Microsoft.AspNetCore.Mvc;
using RoadMapApp.Controllers.Dto;
using RoadMapApp.Services.OptionService;
using RoadMapApp.utils.controller;
using Option = RoadMapApp.Models.Option;

namespace RoadMapApp.Controllers.RestApi;

[ApiController]
[Route("api/option")]
public class OptionApi : ModuleController<Option, OptionDto, IOptionService>
{
    public OptionApi(IContainer container, IMapper mapper):
        base(container, mapper)
    {
    }
        
    [HttpGet("{id:int}")]
    public override Task<ActionResult<OptionDto>> GetById(int id) => base.GetById(id);

    [HttpGet]
    public override Task<ActionResult<List<OptionDto>>> GetAll() => base.GetAll();

    [HttpPost]
    public override Task<ActionResult<OptionDto>> Create(OptionDto dto) => base.Create(dto);

    [HttpGet("optimized")]
    public override Task<ActionResult<List<OptionDto>>> Optimized() => base.Optimized();

    [HttpPost("all")]
    public override Task<ActionResult<List<OptionDto>>> Create(List<OptionDto> dtos) => base.Create(dtos);

    [HttpPut]
    public override Task<ActionResult<OptionDto>> Update(OptionDto dto) => base.Update(dto);

    [HttpPut("all")]
    public override Task<ActionResult<List<OptionDto>>> Update(List<OptionDto> dtos) => base.Update(dtos);

    [HttpDelete("{id:int}")]
    public override Task<ActionResult<int>> Delete(int id) => base.Delete(id);

    [HttpDelete]
    public override Task<ActionResult<int>> Delete(OptionDto dto) => base.Delete(dto);

    [HttpDelete("all")]
    public override Task<ActionResult<int>> Delete(List<OptionDto> dtos) => base.Delete(dtos);

    [HttpPut("update-create")]
    public override Task<ActionResult<OptionDto>> UpdateOrCreate(OptionDto dto) => base.UpdateOrCreate(dto);

    [HttpPut("update-create/all")]
    public override Task<ActionResult<List<OptionDto>>> UpdateOrCreate(List<OptionDto> dtos) => base.UpdateOrCreate(dtos);
}