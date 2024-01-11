using System.Linq.Expressions;
using RoadMapApp.Data;
using RoadMapApp.utils.Module;
using RoadMapApp.utils.Repository.BaseRepository;

namespace RoadMapApp.utils.Repository.AssociationModuleRepository;

/// <summary>
/// Implementation for the repository interface <see cref="IAssociationModuleRepository{TModule}"/>.
/// </summary>
/// <typeparam name="TModule">Type of the module entity.</typeparam>
public abstract class AssociationModuleRepository<TModule> : Repository<TModule>
    where TModule : BaseAssociationModule<TModule>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="AssociationModuleRepository{TModule}"/> class.
    /// </summary>
    /// <param name="context">Your DbContext.</param>
    /// <param name="table">Your DbSet (Table).</param>
    protected AssociationModuleRepository(DataContext context, DbSet<TModule> table) : base(context)
    {
        Table = table.AsQueryable();
        IncludedTable = SetIncluded();
    }

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
    /// Retrieves a single entity of type TModule based on its unique identifier.
    /// </summary>
    /// <param name="item">The unique identifier of the entity.</param>
    /// <returns>A task representing the asynchronous operation and containing the entity.</returns>
    public virtual async Task<TModule> FindByIds(TModule item) => 
        await IncludedTable.FirstOrDefaultAsync(i => i.Equals(item));

    /// <summary>
    /// Deletes a single entity of type TModule from the repository based on its unique identifier.
    /// </summary>
    /// <param name="item">The function to identify the entity to be deleted.</param>
    /// <returns>A task representing the asynchronous operation and containing the number of affected rows.</returns>
    public async Task<int> Delete(TModule item) => 
        await Table.Where(i => i.Equals(item)).ExecuteDeleteAsync();

    public async Task<int> Delete(Expression<Func<TModule, bool>> predicate) => 
        await Table.Where(predicate).ExecuteDeleteAsync();

    /// <summary>
    /// Deletes a list of entities of type TModule from the repository.
    /// </summary>
    /// <param name="items">The function to identify the entities to be deleted.</param>
    /// <returns>A task representing the asynchronous operation and containing the number of affected rows.</returns>
    public virtual async Task<int> Delete(List<TModule> items) => 
        await Table.Where(i => items.Contains(i)).ExecuteDeleteAsync();
}