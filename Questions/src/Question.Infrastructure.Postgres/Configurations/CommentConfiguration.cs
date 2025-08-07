namespace Questions.Infrastructure.Postgres.Configurations;

public class CommentConfiguration : IEntityTypeConfiguration<Domain.Comments.Comment>
{
    public void Configure(EntityTypeBuilder<Domain.Comments.Comment> builder)
    {
        builder.HasKey(c => c.Id);

        builder.Property(a => a.Text)
            .IsRequired();

        builder.Property(c => c.UserId)
            .IsRequired();

        builder.Property(c => c.EntityId)
            .IsRequired();

        builder.Property(c => c.CreatedAt)
              .HasDefaultValueSql("CURRENT_TIMESTAMP AT TIME ZONE 'UTC'");
    }
}
