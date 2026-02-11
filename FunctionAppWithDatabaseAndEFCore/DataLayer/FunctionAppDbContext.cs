using Microsoft.EntityFrameworkCore;

namespace DataLayer;

public class FunctionAppDbContext : DbContext
{
    //public List<Employee> Employees { get; set; }

    public FunctionAppDbContext()
    {
        //blank
    }

    public FunctionAppDbContext(DbContextOptions<FunctionAppDbContext> options)
    : base(options)
    {
        //blank
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            //todo: configure the connection string here, or in the appsettings.json file
            //optionsBuilder.UseSqlServer("Server=localhost;Database=FunctionAppDb;Trusted_Connection=True;");
        }
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
    }
}
