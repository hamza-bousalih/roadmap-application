using AutoMapper;
using Lamar;
using Microsoft.AspNetCore.Mvc;
using RoadMapApp.Controllers.Dto;
using RoadMapApp.Models;
using RoadMapApp.Services.UserService;
using RoadMapApp.utils.controller;

namespace RoadMapApp.Controllers.RestApi;

[ApiController]
[Route("api/user")]
public class UserApi : ModuleController<User, UserDto, IUserService>
{
    public UserApi(IContainer container, IMapper mapper):
        base(container, mapper)
    {
    }

    [HttpGet("{id:int}")]
    public override Task <ActionResult<UserDto>> GetById(int id) => base.GetById(id);

    [HttpGet]
    public override Task <ActionResult<List<UserDto>>> GetAll() => base.GetAll();

    [HttpPost]
    public override Task<ActionResult<UserDto>> Create(UserDto dto) => base.Create(dto);

    [HttpGet("optimized")]
    public override Task<ActionResult<List<UserDto>>> Optimized() => base.Optimized();

    [HttpPost("all")]
    public override Task<ActionResult<List<UserDto>>> Create(List<UserDto> dtos) => base.Create(dtos);

    [HttpPut]
    public override Task<ActionResult<UserDto>> Update(UserDto dto) => base.Update(dto);

    [HttpPut("all")]
    public override Task<ActionResult<List<UserDto>>> Update(List<UserDto> dtos) => base.Update(dtos);

    [HttpDelete("{id:int}")]
    public override Task<ActionResult<int>> Delete(int id) => base.Delete(id);

    [HttpDelete]
    public override Task<ActionResult<int>> Delete(UserDto dto) => base.Delete(dto);

    [HttpDelete("all")]
    public override Task<ActionResult<int>> Delete(List<UserDto> dtos) => base.Delete(dtos);

    [HttpPut("update-create")]
    public override Task<ActionResult<UserDto>> UpdateOrCreate(UserDto dto) => base.UpdateOrCreate(dto);

    [HttpPut("update-create/all")]
    public override Task<ActionResult<List<UserDto>>> UpdateOrCreate(List<UserDto> dtos) => base.UpdateOrCreate(dtos);
}