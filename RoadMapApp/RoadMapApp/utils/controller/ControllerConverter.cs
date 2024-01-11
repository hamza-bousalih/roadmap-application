using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using RoadMapApp.utils.Dto;
using RoadMapApp.utils.Module;

namespace RoadMapApp.utils.controller;

/// <summary>
/// Helper class for controllers providing common operations for mapping between modules and DTOs.
/// </summary>
/// <typeparam name="TModule">Type of the module.</typeparam>
/// <typeparam name="TDto">Type of the Data Transfer Object (DTO).</typeparam>
public abstract class ControllerConverter<TModule, TDto> : ControllerBase
    where TModule : IModule<TModule> 
    where TDto : IDto
{
    private readonly IMapper _mapper;

    /// <summary>
    /// Initializes a new instance of the <see cref="ControllerConverter{TModule,TDto}"/> class.
    /// </summary>
    /// <param name="mapper">AutoMapper instance for mapping entities to DTOs.</param>
    protected ControllerConverter(IMapper mapper) => _mapper = mapper;

    /// <summary>
    /// Converts a module entity to its corresponding DTO representation.
    /// </summary>
    /// <param name="item">The module entity to be converted.</param>
    /// <returns>The DTO representation of the module entity.</returns>
    protected virtual TDto ConvertToDto(TModule item) => _mapper.Map<TDto>(item);

    /// <summary>
    /// Converts a DTO to its corresponding module entity.
    /// </summary>
    /// <param name="dto">The DTO to be converted.</param>
    /// <returns>The module entity represented by the DTO.</returns>
    protected virtual TModule ConvertToItem(TDto dto) => _mapper.Map<TModule>(dto);

    /// <summary>
    /// Converts a module entity to its corresponding DTO representation, handling null input.
    /// </summary>
    /// <param name="item">The module entity to be converted.</param>
    /// <returns>The DTO representation of the module entity or null if the input is null.</returns>
    protected TDto ToDto(TModule item)
    {
        if (item is null) return null;
        var dto = ConvertToDto(item);
        return dto;
    }

    /// <summary>
    /// Converts a DTO to its corresponding module entity, handling null input.
    /// </summary>
    /// <param name="dto">The DTO to be converted.</param>
    /// <returns>The module entity represented by the DTO.</returns>
    /// <exception cref="NullReferenceException">Thrown when the input DTO is null.</exception>
    protected TModule ToItem(TDto dto)
    {
        if (dto is null) throw new NullReferenceException();
        var item = ConvertToItem(dto);
        return item;
    }

    /// <summary>
    /// Converts a collection of DTOs to a list of corresponding module entities.
    /// </summary>
    /// <param name="dtos">The collection of DTOs to be converted.</param>
    /// <returns>A list of module entities represented by the DTOs.</returns>
    protected List<TModule> ToItem(IEnumerable<TDto> dtos) => dtos?.Select(ToItem).ToList();

    /// <summary>
    /// Converts a collection of module entities to a list of corresponding DTO representations.
    /// </summary>
    /// <param name="items">The collection of module entities to be converted.</param>
    /// <returns>A list of DTOs representing the module entities.</returns>
    protected List<TDto> ToDto(IEnumerable<TModule> items) => items?.Select(ToDto).ToList();
}