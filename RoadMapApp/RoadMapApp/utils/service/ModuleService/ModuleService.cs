using Lamar;
using RoadMapApp.utils.Module;
using RoadMapApp.utils.Repository.ModuleRepository;
using RoadMapApp.utils.service.BaseService;

namespace RoadMapApp.utils.service.ModuleService;

public class ModuleService<TModule, TRepository>: Service<TModule, TRepository> 
    where TModule: BaseModule<TModule>
    where TRepository: IModuleRepository<TModule>
{
    public ModuleService(IContainer container) : base(container)
    {
    }
    
    /// <summary>
    /// Retrieves a single entity of type TModule based on its unique identifier.
    /// </summary>
    /// <param name="id">The unique identifier of the entity.</param>
    /// <returns>A task representing the asynchronous operation and containing the entity.</returns>
    public virtual async Task<TModule> GetById(int id) => await Repository.FindById(id);
    
    /// <summary>
    /// Deletes a single entity of type TModule from the repository based on its unique identifier.
    /// </summary>
    /// <param name="id">The unique identifier of the entity to be deleted.</param>
    /// <returns>A task representing the asynchronous operation and containing the number of affected rows.</returns>
    public virtual async Task<int> Delete(int id) => await Repository.Delete(id);

    /// <summary>
    /// Deletes a single entity of type TModule from the repository.
    /// </summary>
    /// <param name="item">The entity to be deleted.</param>
    /// <returns>A task representing the asynchronous operation and containing the number of affected rows.</returns>
    public virtual async Task<int> Delete(TModule item) => await Repository.Delete(item);

    /// <summary>
    /// Deletes a list of entities of type TModule from the repository.
    /// </summary>
    /// <param name="items">The list of entities to be deleted.</param>
    /// <returns>A task representing the asynchronous operation and containing the number of affected rows.</returns>
    public virtual async Task<int> Delete(List<TModule> items) => await Repository.Delete(items);

    /// <summary>
    /// Update or Create An instance of an entity of type TModule in the repository.
    /// </summary>
    /// <param name="item">An instance of entity to be updated.</param>
    /// <returns>A task representing the asynchronous operation and containing the list of updated entities.</returns>
    public virtual async Task<TModule> UpdateOrCreate(TModule item)
    {
        if (item.Id != 0) return await Create(item);
        var fetched = GetById(item.Id);
        if (fetched == null) return await Create(item);
        return await Update(item);
    }

    /// <summary>
    /// Update or Create a list of entities of type TModule in the repository.
    /// </summary>
    /// <param name="items">The list of entities to be updated.</param>
    /// <returns>A task representing the asynchronous operation and containing the list of updated entities.</returns>
    public virtual async Task<List<TModule>> UpdateOrCreate(List<TModule> items)
    {
        throw new NotImplementedException();
        /*var listChanged = new List<TModule>();
        var uncreated = new List<TModule>();
        var created = new List<TModule>();

        foreach (var item in items)
        {
            if (item.Id != 0) uncreated.Add(item);
            var fetched = GetById(item.Id);
            if (fetched == null) uncreated.Add(item);
            else created.Add(item);
        }

        // listChanged.Add(await Create(uncreated));
        // listChanged.Add(await Update(created));

        return listChanged;*/
    }
}