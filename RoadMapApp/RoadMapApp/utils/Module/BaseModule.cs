namespace RoadMapApp.utils.Module;

/// <summary>
/// This abstract class to mark a class as Module with one ID
/// </summary>
/// <typeparam name="TModule">Type of the module.</typeparam>
public abstract class BaseModule<TModule>: IModule<TModule> where TModule: BaseModule<TModule>
{
    public int Id { get; set; }

    public virtual TModule Optimized() => (TModule) this;
}