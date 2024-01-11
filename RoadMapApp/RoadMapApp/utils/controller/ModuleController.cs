using AutoMapper;
using Lamar;
using Microsoft.AspNetCore.Mvc;
using RoadMapApp.utils.Dto;
using RoadMapApp.utils.Module;
using RoadMapApp.utils.service.ModuleService;

namespace RoadMapApp.utils.controller;

/// <summary>
/// Base controller providing common CRUD operations.<br/>
/// </summary>
/// <typeparam name="TModule">Type of the module.</typeparam>
/// <typeparam name="TDto">Type of the Data Transfer Object (DTO).</typeparam>
/// <typeparam name="TService">Type of the service responsible for business logic.</typeparam>
public abstract class ModuleController<TModule, TDto, TService> : BaseController<TModule, TDto, TService>
    where TModule : BaseModule<TModule>
    where TDto : BaseDto
    where TService : IModuleService<TModule>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="BaseController{TModule, TDto, TService}"/> class.
    /// </summary>
    /// <param name="container">Dependency injection container.</param>
    /// <param name="mapper">AutoMapper instance for mapping entities to DTOs.</param>
    protected ModuleController(IContainer container, IMapper mapper) : base(container, mapper)
    {
    }

    /// <summary>
    /// Gets a specific entity by its unique identifier.
    /// </summary>
    /// <param name="id">The identifier of the entity.</param>
    /// <returns>An ActionResult containing the response with the DTO representation of the entity.</returns>
    public virtual async Task<ActionResult<TDto>> GetById(int id) => await FetchAsync(id, Service.GetById);

    /// <summary>
    /// Delete a specific entity by its unique identifier.
    /// </summary>
    /// <param name="id">The identifier of the entity.</param>
    /// <returns>An ActionResult containing the response with the number of the deleted entity.</returns>
    public virtual async Task<ActionResult<int>> Delete(int id) => await DeleteAsync(id, Service.Delete);

    /// <summary>
    /// Delete an instance of specific entity.
    /// </summary>
    /// <param name="dto">The DTO object from the request.</param>
    /// <returns>An ActionResult containing the response with the number of the deleted entity.</returns>
    public virtual async Task<ActionResult<int>> Delete(TDto dto) => await DeleteAsync(dto, Service.Delete);

    /// <summary>
    /// Delete a list of entity's instances.
    /// </summary>
    /// <param name="dtos">The DTOs list from the request.</param>
    /// <returns>An ActionResult containing the response with the number of the deleted entity.</returns>
    public virtual async Task<ActionResult<int>> Delete(List<TDto> dtos) => await DeleteAsync(dtos, Service.Delete);

    /// <summary>
    /// Update or Create a new instances of a specific entity.<br/>
    /// </summary>
    /// <param name="dto">The DTO object from the request.</param>
    /// <returns>An ActionResult containing the response with the DTO representation of the entity.</returns>
    public virtual async Task<ActionResult<TDto>> UpdateOrCreate(TDto dto) => await DoAsync(dto, Service.UpdateOrCreate);

    /// <summary>
    /// Update or Create a new instances of a specific entity.<br/>
    /// </summary>
    /// <param name="dtos">The DTOs list from the request.</param>
    /// <returns>An ActionResult containing the response with the DTO representation of the entity.</returns>
    public virtual async Task<ActionResult<List<TDto>>> UpdateOrCreate(List<TDto> dtos) => await DoAsync(dtos, Service.UpdateOrCreate);
}