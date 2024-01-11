using JasperFx.Core;
using RoadMapApp.Data;
using RoadMapApp.utils.Module;
using RoadMapApp.utils.Repository.BaseRepository;

namespace RoadMapApp.utils.Repository.ModuleRepository;

/// <summary>
/// Implementation for the repository interface <see cref="IModuleRepository{TModule}"/>.
/// </summary>
/// <typeparam name="TModule">Type of the module entity.</typeparam>
public abstract class ModuleRepository<TModule>: Repository<TModule> where TModule : BaseModule<TModule>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ModuleRepository{TModule}"/> class.
    /// </summary>
    /// <param name="context">Your DbContext.</param>
    /// <param name="table">Your DbSet (Table).</param>
    protected ModuleRepository(DataContext context, DbSet<TModule> table) : base(context)
    {
        Table = table.AsQueryable();
        IncludedTable = SetIncluded();
    }

    /// <summary>
    /// Fetch the next property for a specific entity.
    /// </summary>
    /// <param name="next">An instance of type 'TNext' to fetch its next.</param>
    /// <typeparam name="TNext">The Type of the next module.</typeparam>
    /// <returns>The data fetched.</returns>
    protected TNext IncludeNext<TNext>(TNext next) where TNext : NextModule<TNext>
    {
        if (next == null) return null;
        Context.Entry(next)
            .Reference(s => s.Next)
            .Load();
        next.Next = IncludeNext(next.Next);
        return next;
    }

    /// <summary>
    /// Provide a logic for the next fetching.
    /// </summary>
    /// <param name="item">Entity instance.</param>
    protected virtual void FetchNexts(TModule item)
    {
    }
    
    /// <summary>
    /// Retrieves a single entity of type TModule based on its unique identifier.
    /// </summary>
    /// <param name="id">The unique identifier of the entity.</param>
    /// <returns>A task representing the asynchronous operation and containing the entity.</returns>
    public virtual async Task<TModule> FindById(int id)
    {
        var item = await IncludedTable.FirstOrDefaultAsync(i => i.Id == id);
        FetchNexts(item);
        return item;
    }

    /// <summary>
    /// Deletes a single entity of type TModule from the repository based on its unique identifier.
    /// </summary>
    /// <param name="id">The unique identifier of the entity to be deleted.</param>
    /// <returns>A task representing the asynchronous operation and containing the number of affected rows.</returns>
    public virtual async Task<int> Delete(int id) => await Table.Where(t => t.Id == id).ExecuteDeleteAsync();

    /// <summary>
    /// Deletes a single entity of type TModule from the repository.
    /// </summary>
    /// <param name="item">The entity to be deleted.</param>
    /// <returns>A task representing the asynchronous operation and containing the number of affected rows.</returns>
    public virtual async Task<int> Delete(TModule item) => await Delete(item.Id);

    /// <summary>
    /// Deletes a list of entities of type TModule from the repository.
    /// </summary>
    /// <param name="items">The list of entities to be deleted.</param>
    /// <returns>A task representing the asynchronous operation and containing the number of affected rows.</returns>
    public virtual async Task<int> Delete(List<TModule> items)
    {
        var ids = items.Map(i => i.Id);
        return await Table.Where(t => ids.Contains(t.Id)).ExecuteDeleteAsync();
    }
}