namespace RoadMapApp.utils.Module;

/// <summary>
/// This abstract class to mark a module that has NEXT prop (the next have the module type)
/// </summary>
/// <typeparam name="TModule">Type of the module.</typeparam>
public abstract class NextModule<TModule>: BaseModule<TModule> where TModule: BaseModule<TModule>
{
    public TModule Next { get; set; }
}