using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RoadMapApp.Models;

namespace RoadMapApp.Data.Configurations;

public class OptionConfig: IEntityTypeConfiguration<Option>
{
    public void Configure(EntityTypeBuilder<Option> builder)
    {
        builder.Property(e => e.Description).HasMaxLength(1000);
    }
}