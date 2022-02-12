using EyeC.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace EyeC.Infrastructure.Extensions
{
    public static class DbConfig
    {
        public static IServiceCollection AddDbConfig(this IServiceCollection services, String connectionString)
        {
            services.AddDbContext<UserContext>(options => options.UseSqlServer(connectionString,optBuilder=>optBuilder.MigrationsAssembly("EyeC.Infrastructure")));
            return services;
        }
    }
}