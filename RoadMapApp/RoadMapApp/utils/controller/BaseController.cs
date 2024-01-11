using AutoMapper;
using Lamar;
using Microsoft.AspNetCore.Mvc;
using RoadMapApp.utils.Dto;
using RoadMapApp.utils.Module;
using RoadMapApp.utils.service.BaseService;

namespace RoadMapApp.utils.controller;


/// <summary>
/// Base controller providing common CRUD operations.<br/>
/// </summary>
/// <typeparam name="TModule">Type of the module.</typeparam>
/// <typeparam name="TDto">Type of the Data Transfer Object (DTO).</typeparam>
/// <typeparam name="TService">Type of the service responsible for business logic.</typeparam>
public abstract class BaseController<TModule, TDto, TService> : ControllerHelper<TModule, TDto>
    where TModule : IModule<TModule>
    where TDto : IDto
    where TService : IService<TModule>
{
    protected TService Service;
    
    /// <summary>
    /// Initializes a new instance of the <see cref="BaseController{TModule, TDto, TService}"/> class.
    /// </summary>
    /// <param name="container">Dependency injection container.</param>
    /// <param name="mapper">AutoMapper instance for mapping entities to DTOs.</param>
    protected BaseController(IContainer container, IMapper mapper) : base(mapper) =>
        Service = container.GetInstance<TService>();

    /// <summary>
    /// Gets all of the instances of a specific entity.
    /// </summary>
    /// <returns>An ActionResult containing the response with the DTO representation of the entity.</returns>
    public virtual async Task<ActionResult<List<TDto>>> GetAll() => await FetchAsync(Service.Get);

    /// <summary>
    /// Gets all of the instances of a specific entity.<br/>
    /// that are optimized, that mean this method just fetch some properties of the specific entity not all.
    /// </summary>
    /// <returns>An ActionResult containing the response with the DTO representation of the entity.</returns>
    public virtual async Task<ActionResult<List<TDto>>> Optimized() => await FetchAsync(Service.Optimized);

    /// <summary>
    /// Create a new instance of a specific entity.<br/>
    /// </summary>
    /// <param name="dto">The DTO object from the request.</param>
    /// <returns>An ActionResult containing the response with the DTO representation of the entity.</returns>
    public virtual async Task<ActionResult<TDto>> Create(TDto dto) => await DoAsync(dto, Service.Create);

    /// <summary>
    /// Create a new instances of a specific entity.<br/>
    /// </summary>
    /// <param name="dtos">The DTOs list from the request.</param>
    /// <returns>An ActionResult containing the response with the DTO representation of the entity.</returns>
    public virtual async Task<ActionResult<List<TDto>>> Create(List<TDto> dtos) => await DoAsync(dtos, Service.Create);

    /// <summary>
    /// Update an instance of a specific entity.<br/>
    /// </summary>
    /// <param name="dto">The DTO object from the request.</param>
    /// <returns>An ActionResult containing the response with the DTO representation of the entity.</returns>
    public virtual async Task<ActionResult<TDto>> Update(TDto dto) => await DoAsync(dto, Service.Update);

    /// <summary>
    /// Create a new instances of a specific entity.<br/>
    /// </summary>
    /// <param name="dtos">The DTOs list from the request.</param>
    /// <returns>An ActionResult containing the response with the DTO representation of the entity.</returns>
    public virtual async Task<ActionResult<List<TDto>>> Update(List<TDto> dtos) => await DoAsync(dtos, Service.Update);
}