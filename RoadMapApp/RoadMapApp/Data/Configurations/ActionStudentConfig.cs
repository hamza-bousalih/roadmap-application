using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using RoadMapApp.Models;

namespace RoadMapApp.Data.Configurations;

public class ActionStudentConfig: IEntityTypeConfiguration<ActionStudent>
{
    public void Configure(EntityTypeBuilder<ActionStudent> builder)
    {
        builder.HasKey("ActionId", "StudentId");
    }
    
    
}