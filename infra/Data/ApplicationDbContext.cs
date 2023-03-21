using IPediApp.Domain.Products;
using Microsoft.EntityFrameworkCore;

namespace IPediApp.infra.Data;
public class ApplicationDbContext : DbContext
{
    public DbSet<Product> Products { get; set; }
    public DbSet<Category> Categories { get; set; }
    
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        //usando o fluente api
        builder.Entity<Product>()
            .Property(p => p.Description).HasMaxLength(255);

        builder.Entity<Product>()
            .Property(p => p.Name).IsRequired();


        builder.Entity<Category>()
        .Property(p => p.Name).IsRequired();
    }

    protected override void ConfigureConventions(ModelConfigurationBuilder configuration)
    {
        configuration.Properties<string>()
            .HaveMaxLength(100);
    }

}
