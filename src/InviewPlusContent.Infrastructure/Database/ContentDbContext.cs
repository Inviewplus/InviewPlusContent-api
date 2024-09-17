using InviewPlusContent.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace InviewPlusContent.Infrastructure.Database;

public class ContentDbContext : DbContext
{
    public ContentDbContext(DbContextOptions<ContentDbContext> options) : base(options) { }
    
    public DbSet<Content> Contents { get; set; }
    public DbSet<Season> Seasons { get; set; }
    public DbSet<Episode> Episodes { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Content>()
            .HasMany(c => c.Seasons)
            .WithOne()
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<Season>()
            .HasMany(s => s.Episodes)
            .WithOne()
            .OnDelete(DeleteBehavior.Cascade);
    }

}