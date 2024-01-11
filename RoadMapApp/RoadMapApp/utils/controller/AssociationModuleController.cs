using AutoMapper;
using Lamar;
using Microsoft.AspNetCore.Mvc;
using RoadMapApp.utils.Dto;
using RoadMapApp.utils.Module;
using RoadMapApp.utils.service.AssociationService;

namespace RoadMapApp.utils.controller;

/// <summary>
/// Base controller providing common CRUD operations.<br/>
/// </summary>
/// <typeparam name="TAssociation">Type of the module.</typeparam>
/// <typeparam name="TAssociationDto">Type of the Data Transfer Object (DTO).</typeparam>
/// <typeparam name="TService">Type of the service responsible for business logic.</typeparam>
public abstract class
    AssociationModuleController<TAssociation, TAssociationDto, TService> : BaseController<TAssociation, TAssociationDto,
    TService>
    where TAssociation : BaseAssociationModule<TAssociation>
    where TAssociationDto : BaseAssociationDto
    where TService : IAssociationService<TAssociation>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="BaseController{TModule, TDto, TService}"/> class.
    /// </summary>
    /// <param name="container">Dependency injection container.</param>
    /// <param name="mapper">AutoMapper instance for mapping entities to DTOs.</param>
    protected AssociationModuleController(IContainer container, IMapper mapper) : base(container, mapper)
    {
    }

    /// <summary>
    /// Retrieves a single entity of type TAssociation based on its unique identifier.
    /// </summary>
    /// <param name="dto">The entity to fetch its details.</param>
    /// <returns>A task representing the asynchronous operation and containing the entity.</returns>
    public virtual async Task<ActionResult<TAssociationDto>> FindByIds(TAssociationDto dto) =>
        await FetchAsync(dto, Service.FindByIds);

    /// <summary>
    /// Deletes a single entity of type TAssociation from the repository based on its unique identifier.
    /// </summary>
    /// <param name="dto">The entity to be deleted.</param>
    /// <returns>A task representing the asynchronous operation and containing the number of affected rows.</returns>
    public virtual async Task<ActionResult<int>> Delete(TAssociationDto dto) =>
        await DeleteAsync(dto, Service.Delete);

    /// <summary>
    /// Deletes a list of entities of type TAssociation from the repository.
    /// </summary>
    /// <param name="dtos">List of entities to be deleted.</param>
    /// <returns>A task representing the asynchronous operation and containing the number of affected rows.</returns>
    public virtual async Task<ActionResult<int>> Delete(List<TAssociationDto> dtos) =>
        await DeleteAsync(dtos, Service.Delete);
}