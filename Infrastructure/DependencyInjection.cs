using Infrastructure.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;

namespace Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
            services.AddSingleton<MockDatabase>();
            services.AddDbContext<AppDbContext>(options =>
            {
                //connectionString to Db
                string connectionString = "Server=localhost;Port=3306;Database=API_Animals;User=root;Password=mustafa0909;";

                options.UseMySql(connectionString, new MySqlServerVersion(new Version(8, 0, 35)));
            });

            return services;
        }
    }
}
