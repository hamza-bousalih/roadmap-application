using System.Linq.Expressions;
using Lamar;
using RoadMapApp.utils.Module;
using RoadMapApp.utils.Repository.AssociationModuleRepository;
using RoadMapApp.utils.service.BaseService;

namespace RoadMapApp.utils.service.AssociationService;

public class AssociationService<TAssociation, TRepository> : Service<TAssociation, TRepository>,
    IAssociationService<TAssociation>
    where TAssociation : BaseAssociationModule<TAssociation>
    where TRepository : IAssociationModuleRepository<TAssociation>
{
    public AssociationService(IContainer container) : base(container)
    {
    }

    /// <summary>
    /// Retrieves a single entity of type TAssociation based on its unique identifier.
    /// </summary>
    /// <param name="item">The function to identify the entity.</param>
    /// <returns>A task representing the asynchronous operation and containing the entity.</returns>
    public async Task<TAssociation> FindByIds(TAssociation item) =>
        await Repository.FindByIds(item);

    /// <summary>
    /// Deletes a single entity of type TAssociation from the repository based on its unique identifier.
    /// </summary>
    /// <param name="item">The function to identify the entity to be deleted.</param>
    /// <returns>A task representing the asynchronous operation and containing the number of affected rows.</returns>
    public async Task<int> Delete(TAssociation item) =>
        await Repository.Delete(item);

    /// <summary>
    /// Deletes a list of entities of type TAssociation from the repository.
    /// </summary>
    /// <param name="items">The function to identify the entities to be deleted.</param>
    /// <returns>A task representing the asynchronous operation and containing the number of affected rows.</returns>
    public async Task<int> Delete(List<TAssociation> items) =>
        await Repository.Delete(items);
}