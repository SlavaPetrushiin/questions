using Questions.Domain.Reports;

namespace Questions.Infrastructure.Postgres.Configurations;

public class ReportConfiguration : IEntityTypeConfiguration<Report>
{
    public void Configure(EntityTypeBuilder<Report> builder)
    {
        builder.HasKey(r => r.Id);


        builder.Property(r => r.UserId)
            .IsRequired();

        builder.Property(r => r.ReportedUserId)
             .IsRequired();

        builder.Property(r => r.Reason)
             .IsRequired();

        builder.Property(r => r.Status)
             .HasDefaultValue(ReportStatus.Open);

        builder.Property(r => r.ResolvedByUserId)
            .IsRequired(false);

        builder.Property(r => r.CreatedAt)
              .HasDefaultValueSql("CURRENT_TIMESTAMP AT TIME ZONE 'UTC'");

        builder.HasIndex(r => r.Status);
    }
}
