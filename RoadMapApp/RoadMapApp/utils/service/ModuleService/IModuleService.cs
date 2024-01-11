using RoadMapApp.utils.Module;
using RoadMapApp.utils.service.BaseService;

namespace RoadMapApp.utils.service.ModuleService;

public interface IModuleService<TModule>: IService<TModule> where TModule: BaseModule<TModule>
{
    /// <summary>
    /// Update or Create An instance of an entity of type TModule in the repository.
    /// </summary>
    /// <param name="item">An instance of entity to be updated.</param>
    /// <returns>A task representing the asynchronous operation and containing the list of updated entities.</returns>
    Task<TModule> UpdateOrCreate(TModule item);

    /// <summary>
    /// Update or Create a list of entities of type TModule in the repository.
    /// </summary>
    /// <param name="items">The list of entities to be updated.</param>
    /// <returns>A task representing the asynchronous operation and containing the list of updated entities.</returns>
    Task<List<TModule>> UpdateOrCreate(List<TModule> items);
    
    /// <summary>
    /// Retrieves a single entity of type TModule based on its unique identifier.
    /// </summary>
    /// <param name="id">The unique identifier of the entity.</param>
    /// <returns>A task representing the asynchronous operation and containing the entity.</returns>
    Task<TModule> GetById(int id);
    
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