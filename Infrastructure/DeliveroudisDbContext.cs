using Domain.Stores;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure;

public class DeliveroudisDbContext : DbContext
{
    public DeliveroudisDbContext(DbContextOptions<DeliveroudisDbContext> options) : base(options)
    {
    }

    public DbSet<Store> Stores { get; set; }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
        => modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly);
}
