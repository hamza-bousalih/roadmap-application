using Lamar;
using RoadMapApp.utils.Module;
using RoadMapApp.utils.Repository.BaseRepository;
using RoadMapApp.utils.Repository.ModuleRepository;

namespace RoadMapApp.utils.service.BaseService;

public abstract class Service<TModule, TRepository> /*: ServiceHelper<TModule>*/
    where TModule : IModule<TModule>
    where TRepository : IRepository<TModule>
{
    protected TRepository Repository;

    /// <summary>
    /// Initializes a new instance of the <see cref="Service{TModule,TRepository}"/> class.
    /// </summary>
    /// <param name="container">Dependency injection container.</param>
    protected Service(IContainer container) =>
        Repository = container.GetInstance<TRepository>();

    /// <summary>
    /// Saves a single entity of type TModule to the repository.
    /// </summary>
    /// <param name="item">The entity to be saved.</param>
    /// <returns>A task representing the asynchronous operation and containing the saved entity.</returns>
    public virtual async Task<TModule> Create(TModule item) => await Repository.Save(item);

    /// <summary>
    /// Saves a list of entities of type TModule to the repository.
    /// </summary>
    /// <param name="items">The list of entities to be saved.</param>
    /// <returns>A task representing the asynchronous operation and containing the list of saved entities.</returns>
    public virtual async Task<List<TModule>> Create(List<TModule> items) => await Repository.Save(items);
    
    /// <summary>
    /// Retrieves all entities of type TModule from the database.
    /// </summary>
    /// <returns>A task representing the asynchronous operation and containing a list of entities.</returns>
    public virtual async Task<List<TModule>> Get() => await Repository.FindAll();

    /// <summary>
    /// Retrieves entities optimized for dropdown lists.
    /// </summary>
    /// <returns>A task representing the asynchronous operation and containing a list of optimized entities.</returns>
    public virtual async Task<List<TModule>> Optimized() => await Repository.Optimized();

    /// <summary>
    /// Updates a single entity of type TModule in the repository.
    /// </summary>
    /// <param name="item">The entity to be updated.</param>
    /// <returns>A task representing the asynchronous operation and containing the updated entity.</returns>
    public virtual async Task<TModule> Update(TModule item) => await Repository.Update(item);

    /// <summary>
    /// Updates a list of entities of type TModule in the repository.
    /// </summary>
    /// <param name="items">The list of entities to be updated.</param>
    /// <returns>A task representing the asynchronous operation and containing the list of updated entities.</returns>
    public virtual async Task<List<TModule>> Update(List<TModule> items) => await Repository.Update(items);
}