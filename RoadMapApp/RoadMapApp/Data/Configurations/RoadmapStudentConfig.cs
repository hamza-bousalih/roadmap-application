using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RoadMapApp.Models;

namespace RoadMapApp.Data.Configurations;

public class RoadmapStudentConfig: IEntityTypeConfiguration<RoadmapStudent>
{
    public void Configure(EntityTypeBuilder<RoadmapStudent> builder)
    {
        builder.HasKey("RoadmapId", "StudentId");
    }
}