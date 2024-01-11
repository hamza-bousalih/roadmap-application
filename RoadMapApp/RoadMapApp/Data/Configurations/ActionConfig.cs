using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Action = RoadMapApp.Models.Action;

namespace RoadMapApp.Data.Configurations;

public class ActionConfig: IEntityTypeConfiguration<Action>
{
    public void Configure(EntityTypeBuilder<Action> builder)
    {
        
    }
}