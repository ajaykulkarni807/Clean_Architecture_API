public class AppDbContext : DbContext
{
    public DbSet<Product> Products { get; set; }
    // other DbSets
}