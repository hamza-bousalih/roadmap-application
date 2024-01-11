namespace RoadMapApp.utils.Module;

/// <summary>
/// This abstract class to mark the modules that represent the associations between the other modules<br/>
/// it usually have tow or more of IDs 
/// </summary>
/// <typeparam name="TAssociation">Type of the association module.</typeparam>
public abstract class BaseAssociationModule<TAssociation>: IModule<TAssociation>
    where TAssociation: BaseAssociationModule<TAssociation>
{
    public abstract bool Equals(TAssociation obj);
    public abstract bool NoNull();
    public virtual TAssociation Optimized() => (TAssociation) this;
}