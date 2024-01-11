using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using RoadMapApp.utils.Dto;
using RoadMapApp.utils.Module;

namespace RoadMapApp.utils.controller;

public abstract class ControllerHelper<TModule, TDto>: ControllerConverter<TModule, TDto>
    where TModule : IModule<TModule> 
    where TDto : IDto
{
    protected ControllerHelper(IMapper mapper) : base(mapper)
    {
    }

    protected async Task<ActionResult<TDto>> DoAsync(TDto dto, Func<TModule, Task<TModule>> process)
    {
        var item = ToItem(dto);
        var result = await process.Invoke(item);
        return Ok(ToDto(result));
    }

    protected async Task<ActionResult<List<TDto>>> DoAsync(IEnumerable<TDto> dtos, Func<List<TModule>, Task<List<TModule>>> process)
    {
        var item = ToItem(dtos);
        var result = await process.Invoke(item);
        return Ok(ToDto(result));
    }
    
    protected async Task<ActionResult<int>> DeleteAsync(int param, Func<int, Task<int>> process)
    {
        var result = await process.Invoke(param);
        return Ok(result);
    }
    
    protected async Task<ActionResult<int>> DeleteAsync(TDto dto, Func<TModule, Task<int>> process)
    {
        var item = ToItem(dto);
        var result = await process.Invoke(item);
        return Ok(result);
    }

    protected async Task<ActionResult<int>> DeleteAsync(IEnumerable<TDto> dtos, Func<List<TModule>, Task<int>> process)
    {
        var item = ToItem(dtos);
        var result = await process.Invoke(item);
        return Ok(result);
    }

    protected async Task<ActionResult<List<TDto>>> FetchAsync(Func<Task<List<TModule>>> process)
    {
        var result = await process.Invoke();
        return Ok(ToDto(result));
    }

    protected async Task<ActionResult<TDto>> FetchAsync(Func<Task<TModule>> process)
    {
        var result = await process.Invoke();
        return Ok(ToDto(result));
    }

    protected async Task<ActionResult<TDto>> FetchAsync(TDto dto, Func<TModule,Task<TModule>> process) => 
        await DoAsync(dto, process);

    protected async Task<ActionResult<TDto>> FetchAsync(int param, Func<int, Task<TModule>> process)
    {
        var result = await process.Invoke(param);
        return Ok(ToDto(result));
    }
    
    protected async Task<ActionResult<TDto>> FetchAsync(int param1,int param2, Func<int, int, Task<TModule>> process)
    {
        var result = await process.Invoke(param1, param2);
        return Ok(ToDto(result));
    }
    
    protected async Task<ActionResult<List<TDto>>> FetchListAsync(int param, Func<int, Task<List<TModule>>> process)
    {
        var result = await process.Invoke(param);
        return Ok(ToDto(result));
    }
}