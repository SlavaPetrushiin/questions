using Questions.Domain.Tag;

namespace Questions.Infrastructure.Postgres.Configurations;

public class TagConfiguration : IEntityTypeConfiguration<Tag>
{
    public void Configure(EntityTypeBuilder<Tag> builder)
    {
        builder.HasKey(t => t.Id);

        builder.Property(t => t.Name)
              .IsRequired();

        builder.Property(t => t.Description)
              .IsRequired();
    }
}
