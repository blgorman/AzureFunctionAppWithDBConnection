using Microsoft.EntityFrameworkCore;

namespace DataLayer;

public class FunctionAppDbContext : DbContext
{
    //public List<Employee> Employees { get; set; }

    public FunctionAppDbContext(DbContextOptions<FunctionAppDbContext> options)
    : base(options)
    {
        //blank
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
    }
}
