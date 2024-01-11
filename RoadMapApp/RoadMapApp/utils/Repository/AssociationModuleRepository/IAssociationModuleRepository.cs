using System.Linq.Expressions;
using RoadMapApp.utils.Module;
using RoadMapApp.utils.Repository.BaseRepository;

namespace RoadMapApp.utils.Repository.AssociationModuleRepository;

/// <summary>
/// Interface for a generic repository providing CRUD operations for entities.
/// </summary>
/// <typeparam name="TAssociation">Type of the module entity.</typeparam>
public interface IAssociationModuleRepository<TAssociation>: IRepository<TAssociation> where TAssociation : BaseAssociationModule<TAssociation>
{
    /// <summary>
    /// Retrieves a single entity of type TModule based on its unique identifier.
    /// </summary>
    /// <param name="item">The function to identify the entity.</param>
    /// <returns>A task representing the asynchronous operation and containing the entity.</returns>
    Task<TAssociation> FindByIds(TAssociation item);

    /// <summary>
    /// Deletes a single entity of type TModule from the repository based on its unique identifier.
    /// </summary>
    /// <param name="item">The function to identify the entity to be deleted.</param>
    /// <returns>A task representing the asynchronous operation and containing the number of affected rows.</returns>
    Task<int> Delete(TAssociation item);

    /// <summary>
    /// Deletes a list of entities of type TModule from the repository.
    /// </summary>
    /// <param name="items">The function to identify the entities to be deleted.</param>
    /// <returns>A task representing the asynchronous operation and containing the number of affected rows.</returns>
    Task<int> Delete(List<TAssociation> items);
}