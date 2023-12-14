﻿using Infrastructure.Database;
using Infrastructure.Repositories.Authorization;
using Infrastructure.Repositories.Dogs;
using Infrastructure.Repositories.Users;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
            services.AddSingleton<MockDatabase>();
            services.AddScoped<IAuthRepository, AuthRepository>();
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IDogRepository, DogRepository>();
            services.AddDbContext<AppDbContext>(options =>
            {
                //connectionString to Db
                var connectionString = "Server=localhost;Port=3306;Database=API_Animals;User=root;Password=mustafa0909;";

                options.UseMySql(connectionString, new MySqlServerVersion(new Version(8, 0, 35)));
            });

            return services;
        }
    }
}
