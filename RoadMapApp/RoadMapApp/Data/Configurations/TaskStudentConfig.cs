using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RoadMapApp.Models;

namespace RoadMapApp.Data.Configurations;

public class TaskStudentConfig: IEntityTypeConfiguration<TaskStudent>
{
    public void Configure(EntityTypeBuilder<TaskStudent> builder)
    {
        builder.HasKey("TaskId", "StudentId");
    }
}