using System.Diagnostics.CodeAnalysis;
using System.Linq.Expressions;
using RoadMapApp.Data;
using RoadMapApp.utils.Module;

namespace RoadMapApp.utils.Repository.BaseRepository;

/// <summary>
/// Implementation for the repository interface <see cref="IRepository{TModule}"/>.
/// </summary>
/// <typeparam name="TModule">Type of the module entity.</typeparam>
public abstract class Repository<TModule> where TModule : IModule<TModule>
{
    protected readonly DataContext Context;
    protected IQueryable<TModule> Table;
    protected IQueryable<TModule> IncludedTable;

    /// <summary>
    /// Initializes a new instance of the <see cref="Repository{TModule}"/> class.
    /// </summary>
    /// <param name="context">Your DbContext.</param>
    protected Repository(DataContext context) => Context = context;

    /// <summary>
    /// Mark the properties of Type Module as 'EntityState.Unchanged'.
    /// </summary>
    /// <param name="item"></param>
    protected virtual void SetContextEntry(TModule item)
    {
    }

    /// <summary>
    /// Set the included modules that you want to fetch them when fetching the specific entity. 
    /// </summary>
    protected virtual IQueryable<TModule> SetIncluded() => Table;

    /// <summary>
    /// Mark the provided property of Type Module as 'EntityState.Unchanged' if it has an ID.
    /// </summary>
    /// <param name="property"></param>
    protected new void SetEntry<TProperty>(TProperty property) where TProperty : BaseModule<TProperty>
    {
        if (property != null && property.Id != 0)
            Context.Entry(property).State = EntityState.Unchanged;
    }
    
    /// <summary>
    /// Mark the provided property of Type Module as 'EntityState.Unchanged' if it has an ID.
    /// </summary>
    /// <param name="properties"></param>
    protected void SetEntry<TProperty>(List<TProperty> properties) where TProperty : BaseModule<TProperty>
    {
        foreach (var property in properties) SetEntry(property);
    }
    
    /// <summary>
    /// Retrieves all entities of type TModule from the repository.
    /// </summary>
    /// <returns>A task representing the asynchronous operation and containing a list of entities.</returns>
    public virtual async Task<List<TModule>> FindAll() => await IncludedTable.ToListAsync();

    /// <summary>
    /// Retrieves entities of type TModule based on the provided filter predicate.
    /// </summary>
    /// <param name="predicate">The filter predicate.</param>
    /// <returns>A task representing the asynchronous operation and containing a list of filtered entities.</returns>
    public virtual async Task<List<TModule>> Filter([NotNull] Expression<Func<TModule, bool>> predicate)
    {
        var result = await IncludedTable.Where(predicate).ToListAsync();
        return result;
    }

    /// <summary>
    /// Retrieves entities optimized for dropdown lists.
    /// </summary>
    /// <returns>A task representing the asynchronous operation and containing a list of optimized entities.</returns>
    public virtual async Task<List<TModule>> Optimized() => 
        await IncludedTable.Select(module => module.Optimized()).ToListAsync();

    /// <summary>
    /// Saves a single entity of type TModule to the repository.
    /// </summary>
    /// <param name="item">The entity to be saved.</param>
    /// <returns>A task representing the asynchronous operation and containing the saved entity.</returns>
    public virtual async Task<TModule> Save(TModule item)
    {
        Context.Add(item);
        SetContextEntry(item);
        await Context.SaveChangesAsync();
        return item;
    }

    /// <summary>
    /// Saves a list of entities of type TModule to the repository.
    /// </summary>
    /// <param name="items">The list of entities to be saved.</param>
    /// <returns>A task representing the asynchronous operation and containing the list of saved entities.</returns>
    public virtual async Task<List<TModule>> Save(List<TModule> items)
    {
        Context.AddRange(items);
        foreach (var roadmap in items) SetContextEntry(roadmap);
        await Context.SaveChangesAsync();
        return items;
    }

    /// <summary>
    /// Updates a single entity of type TModule in the repository.
    /// </summary>
    /// <param name="item">The entity to be updated.</param>
    /// <returns>A task representing the asynchronous operation and containing the updated entity.</returns>
    public virtual async Task<TModule> Update(TModule item)
    {
        Context.Update(item);
        await Context.SaveChangesAsync();
        return item;
    }

    /// <summary>
    /// Updates a list of entities of type TModule in the repository.
    /// </summary>
    /// <param name="items">The list of entities to be updated.</param>
    /// <returns>A task representing the asynchronous operation and containing the list of updated entities.</returns>
    public virtual async Task<List<TModule>> Update(List<TModule> items)
    {
        Context.UpdateRange(items);
        await Context.SaveChangesAsync();
        return items;
    }
}