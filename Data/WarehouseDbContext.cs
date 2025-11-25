using Microsoft.EntityFrameworkCore;
using SmartWarehouse.Api.Models;

public class WarehouseDbContext : DbContext
{
    public WarehouseDbContext(DbContextOptions<WarehouseDbContext> options) : base(options)
    {
    }

    public DbSet<Product> Products { get; set; }
}
