using Entities;
using Microsoft.EntityFrameworkCore;

namespace Repository;

public class RepositoryContext:DbContext
{
    public RepositoryContext(DbContextOptions options)
        : base(options) { }
    
    public DbSet<Employee>? Employees { get; set; }
    public DbSet<Wage>? Wages { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
    }
}