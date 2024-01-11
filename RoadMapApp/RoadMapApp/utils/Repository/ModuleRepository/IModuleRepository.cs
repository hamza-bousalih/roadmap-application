using System.Linq.Expressions;
using RoadMapApp.utils.Module;
using RoadMapApp.utils.Repository.BaseRepository;

namespace RoadMapApp.utils.Repository.ModuleRepository;

/// <summary>
/// Interface for a generic repository providing CRUD operations for entities.
/// </summary>
/// <typeparam name="TModule">Type of the module entity.</typeparam>
public interface IModuleRepository<TModule>: IRepository<TModule> where TModule : IModule<TModule>
{
    /// <summary>
    /// Retrieves a single entity of type TModule based on its unique identifier.
    /// </summary>
    /// <param name="id">The unique identifier of the entity.</param>
    /// <returns>A task representing the asynchronous operation and containing the entity.</returns>
    Task<TModule> FindById(int id);

    /// <summary>
    /// Deletes a single entity of type TModule from the repository based on its unique identifier.
    /// </summary>
    /// <param name="id">The unique identifier of the entity to be deleted.</param>
    /// <returns>A task representing the asynchronous operation and containing the number of affected rows.</returns>
    Task<int> Delete(int id);
    
    /// <summary>
    /// Deletes a single entity of type TModule from the repository.
    /// </summary>
    /// <param name="item">The entity to be deleted.</param>
    /// <returns>A task representing the asynchronous operation and containing the number of affected rows.</returns>
    Task<int> Delete(TModule item);

    /// <summary>
    /// Deletes a list of entities of type TModule from the repository.
    /// </summary>
    /// <param name="items">The list of entities to be deleted.</param>
    /// <returns>A task representing the asynchronous operation and containing the number of affected rows.</returns>
    Task<int> Delete(List<TModule> items);
}