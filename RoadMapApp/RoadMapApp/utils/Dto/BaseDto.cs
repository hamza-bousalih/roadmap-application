namespace RoadMapApp.utils.Dto;

/// <summary>
/// This abstract class to mark the dto that have one ID
/// </summary>
public abstract class BaseDto: IDto
{
    public int Id { get; set; }
}