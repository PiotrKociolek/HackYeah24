using FitLife.entities;
using Microsoft.EntityFrameworkCore;

namespace FitLife.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Hardcodowane pytania
        modelBuilder.Entity<Question>().HasData(
            new Question { Id = 1, Content = "Który opis pasuje do ciebie?", IsHardcoded = true, IsPredefined = true},
            new Question { Id = 2, Content = "Co dzisiaj robiłeś i ile czasu to trwało?", IsHardcoded = true },
            new Question { Id = 3, Content = "Co pozytywnego stało się w dzisiejszym dniu", IsHardcoded = true },
            new Question { Id = 4, Content = "Co mogłem zrobić lepiej?", IsHardcoded = true },
            new Question { Id = 5, Content = "Co dzisiaj najbardziej wpłynęło na Twoje samopoczucie?", IsHardcoded = true }
        );
    }

    public DbSet<User> Users { get; set; }
    public DbSet<Specialist> Specialists { get; set; }
    public DbSet<Post> Posts { get; set; }
    public DbSet<Question> Questions { get; set; }
    public DbSet<Answer> Answers { get; set; }
}