using System.Linq.Expressions;
using RoadMapApp.utils.Module;
using RoadMapApp.utils.service.BaseService;

namespace RoadMapApp.utils.service.AssociationService;

public interface IAssociationService<TAssociation>: IService<TAssociation> where TAssociation: BaseAssociationModule<TAssociation>
{
    /// <summary>
    /// Retrieves a single entity of type TAssociation based on its unique identifier.
    /// </summary>
    /// <param name="item">The entity to fetch its details.</param>
    /// <returns>A task representing the asynchronous operation and containing the entity.</returns>
    Task<TAssociation> FindByIds(TAssociation item);

    /// <summary>
    /// Deletes a single entity of type TAssociation from the repository based on its unique identifier.
    /// </summary>
    /// <param name="item">The entity to be deleted.</param>
    /// <returns>A task representing the asynchronous operation and containing the number of affected rows.</returns>
    Task<int> Delete(TAssociation item);

    /// <summary>
    /// Deletes a list of entities of type TAssociation from the repository.
    /// </summary>
    /// <param name="items">The function to identify the entities to be deleted.</param>
    /// <returns>A task representing the asynchronous operation and containing the number of affected rows.</returns>
    Task<int> Delete(List<TAssociation> items);
}