using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RoadMapApp.Models;

namespace RoadMapApp.Data.Configurations;

public class StudentConfig: IEntityTypeConfiguration<Student>
{
    public void Configure(EntityTypeBuilder<Student> builder)
    {
        
    }
}