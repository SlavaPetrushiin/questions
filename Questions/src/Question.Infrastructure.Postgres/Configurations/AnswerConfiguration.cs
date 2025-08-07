namespace Questions.Infrastructure.Postgres.Configurations;

public class AnswerConfiguration : IEntityTypeConfiguration<Domain.Questions.Answer>
{
    public void Configure(EntityTypeBuilder<Domain.Questions.Answer> builder)
    {
        builder.HasKey(a => a.Id);

        builder.Property(a => a.Text)
            .IsRequired();

        builder.Property(a => a.UserId)
            .IsRequired();
    }
}

