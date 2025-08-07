using System.Reflection;

namespace Question.Infrastructure.Postgres;
public class QuestionsDbContext : DbContext
{
    public DbSet<Questions.Domain.Questions.Question> Questions { get; set; }

    public DbSet<Questions.Domain.Questions.Answer> Answers { get; set; }

    public DbSet<Questions.Domain.Comments.Comment> Comments { get; set; }

    public DbSet<Questions.Domain.Reports.Report> Reports { get; set; }

    public DbSet<Questions.Domain.Tag.Tag> Tags { get; set; }

    public QuestionsDbContext(DbContextOptions options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(
                Assembly.GetExecutingAssembly()
            );
    }
}
