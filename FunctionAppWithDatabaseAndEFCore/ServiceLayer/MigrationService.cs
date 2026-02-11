using DataLayer;
using Microsoft.EntityFrameworkCore;
using Models;

namespace ServiceLayer;

public class MigrationService
{
    private readonly FunctionAppDbContext _db;
    public MigrationService(FunctionAppDbContext context)
    {
        _db = context;
    }

    public void MigrateDatabase()
    {
        _db.Database.Migrate();
    }
}
