using AutoMapper;
using Lamar;
using Microsoft.AspNetCore.Mvc;
using RoadMapApp.Controllers.Dto;
using RoadMapApp.Services.ActionService;
using RoadMapApp.utils.controller;
using Action = RoadMapApp.Models.Action;

namespace RoadMapApp.Controllers.RestApi;

[ApiController]
[Route("api/action")]
public class ActionApi : ModuleController<Action, ActionDto, IActionService>
{
    public ActionApi(IContainer container, IMapper mapper):
        base(container, mapper)
    {
    }
        
    [HttpGet("{id:int}")]
    public override Task <ActionResult<ActionDto>> GetById(int id) => base.GetById(id);

    [HttpGet]
    public override Task <ActionResult<List<ActionDto>>> GetAll() => base.GetAll();

    [HttpPost]
    public override Task<ActionResult<ActionDto>> Create(ActionDto dto) => base.Create(dto);

    [HttpGet("optimized")]
    public override Task<ActionResult<List<ActionDto>>> Optimized() => base.Optimized();

    [HttpPost("all")]
    public override Task<ActionResult<List<ActionDto>>> Create(List<ActionDto> dtos) => base.Create(dtos);

    [HttpPut]
    public override Task<ActionResult<ActionDto>> Update(ActionDto dto) => base.Update(dto);

    [HttpPut("all")]
    public override Task<ActionResult<List<ActionDto>>> Update(List<ActionDto> dtos) => base.Update(dtos);

    [HttpDelete("{id:int}")]
    public override Task<ActionResult<int>> Delete(int id) => base.Delete(id);

    [HttpDelete]
    public override Task<ActionResult<int>> Delete(ActionDto dto) => base.Delete(dto);

    [HttpDelete("all")]
    public override Task<ActionResult<int>> Delete(List<ActionDto> dtos) => base.Delete(dtos);

    [HttpPut("update-create")]
    public override Task<ActionResult<ActionDto>> UpdateOrCreate(ActionDto dto) => base.UpdateOrCreate(dto);

    [HttpPut("update-create/all")]
    public override Task<ActionResult<List<ActionDto>>> UpdateOrCreate(List<ActionDto> dtos) => base.UpdateOrCreate(dtos);
}