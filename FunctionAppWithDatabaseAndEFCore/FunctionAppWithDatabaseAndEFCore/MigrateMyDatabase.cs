using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;
using ServiceLayer;

namespace FunctionAppWithDatabaseAndEFCore;

public class MigrateMyDatabase
{
    private readonly MigrationService _migrationService;
    private readonly ILogger<MigrateMyDatabase> _logger;

    public MigrateMyDatabase(ILogger<MigrateMyDatabase> logger, MigrationService migrationService)
    {
        _logger = logger;
        _migrationService = migrationService;
    }

    [Function("MigrateMyDatabase")]
    public IActionResult Run([HttpTrigger(AuthorizationLevel.Function, "get")] HttpRequest req)
    {
        _logger.LogInformation("Migrating database");

        _migrationService.MigrateDatabase();

        return new OkObjectResult("Database migrated successfully!");
    }
}