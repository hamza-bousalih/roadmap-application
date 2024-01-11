using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RoadMapApp.Models;

namespace RoadMapApp.Data.Configurations;

public class SectionConfig: IEntityTypeConfiguration<Section>
{
    public void Configure(EntityTypeBuilder<Section> builder)
    {
        
    }
}