namespace Questions.Infrastructure.Postgres.Configurations;

public class QuestionConfiguration : IEntityTypeConfiguration<Domain.Questions.Question>
{
    public void Configure(EntityTypeBuilder<Domain.Questions.Question> builder)
    {
        builder.HasKey(q => q.Id);

        builder.HasMany(q => q.Answers)
            .WithOne(a => a.Question)
            .HasForeignKey(x => x.QuestionId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasOne(q => q.Solution)
            .WithOne()
            .HasForeignKey<Domain.Questions.Question>(q => q.SolutionId)
            .IsRequired(false);

        builder.Property(q => q.UserId)
                .IsRequired();
    }
}

