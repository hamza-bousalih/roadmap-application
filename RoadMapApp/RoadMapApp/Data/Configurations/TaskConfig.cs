using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Task = RoadMapApp.Models.Task;

namespace RoadMapApp.Data.Configurations;

public class TaskConfig: IEntityTypeConfiguration<Task>
{
    public void Configure(EntityTypeBuilder<Task> builder)
    {
        
    }
}