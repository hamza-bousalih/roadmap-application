using System.Linq.Expressions;
using RoadMapApp.utils.Module;

namespace RoadMapApp.utils.Repository.BaseRepository;

/// <summary>
/// Interface for a generic repository providing CRUD operations for entities.
/// </summary>
/// <typeparam name="TModule">Type of the module entity.</typeparam>
public interface IRepository<TModule> where TModule : IModule<TModule>
{
    /// <summary>
    /// Retrieves all entities of type TModule from the DB.
    /// </summary>
    /// <returns>A task representing the asynchronous operation and containing a list of entities.</returns>
    Task<List<TModule>> FindAll();

    /// <summary>
    /// Retrieves entities of type TModule based on the provided filter predicate.
    /// </summary>
    /// <param name="predicate">The filter predicate.</param>
    /// <returns>A task representing the asynchronous operation and containing a list of filtered entities.</returns>
    Task<List<TModule>> Filter(Expression<Func<TModule, bool>> predicate);

    /// <summary>
    /// Retrieves entities optimized for dropdown lists.
    /// </summary>
    /// <returns>A task representing the asynchronous operation and containing a list of optimized entities.</returns>
    Task<List<TModule>> Optimized();

    /// <summary>
    /// Saves a single entity of type TModule to the repository.
    /// </summary>
    /// <param name="item">The entity to be saved.</param>
    /// <returns>A task representing the asynchronous operation and containing the saved entity.</returns>
    Task<TModule> Save(TModule item);

    /// <summary>
    /// Saves a list of entities of type TModule to the repository.
    /// </summary>
    /// <param name="items">The list of entities to be saved.</param>
    /// <returns>A task representing the asynchronous operation and containing the list of saved entities.</returns>
    Task<List<TModule>> Save(List<TModule> items);

    /// <summary>
    /// Updates a single entity of type TModule in the repository.
    /// </summary>
    /// <param name="item">The entity to be updated.</param>
    /// <returns>A task representing the asynchronous operation and containing the updated entity.</returns>
    Task<TModule> Update(TModule item);

    /// <summary>
    /// Updates a list of entities of type TModule in the repository.
    /// </summary>
    /// <param name="items">The list of entities to be updated.</param>
    /// <returns>A task representing the asynchronous operation and containing the list of updated entities.</returns>
    Task<List<TModule>> Update(List<TModule> items);
}