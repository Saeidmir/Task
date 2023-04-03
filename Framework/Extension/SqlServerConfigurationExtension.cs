using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Framework.Extension;

public static class SqlSerevrConfigurationExtension
{
    public static void AddSqlDbContext<T>(this IServiceCollection services, IConfiguration configuration ) where T : DbContext
    {
        services.AddDbContext<T>(opts =>
        {
#if DEBUG
            opts.UseSqlServer(configuration[
                "ConnectionStrings:DevelopConnection"]);
            opts.EnableSensitiveDataLogging(true);
#elif STAGE
                    opts.UseSqlServer(configuration[
                        "ConnectionStrings:StageConnection"]);
#else
                    opts.UseSqlServer(configuration[
                        "ConnectionStrings:ProductConnection"]);
#endif
        });
    }

}