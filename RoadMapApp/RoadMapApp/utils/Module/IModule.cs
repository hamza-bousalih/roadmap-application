namespace RoadMapApp.utils.Module;

/// <summary>
/// This interface to mark a class as Module
/// </summary>
/// <typeparam name="TModule">Type of the module.</typeparam>
public interface IModule<out TModule> where TModule: IModule<TModule>
{
    public TModule Optimized();
}