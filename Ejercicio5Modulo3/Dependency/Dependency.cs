

using Ejercicio5Modulo3.Repository;
using Microsoft.AspNetCore.Cors.Infrastructure;
using Microsoft.EntityFrameworkCore;

public static class Dependency
{
    public static void AddDependencyCustom(this IServiceCollection services, ConfigurationManager builder)
    {
        services.AddDbContext<Ejercicio5Modulo3Context>
            (options => options.UseSqlServer(builder.GetConnectionString("DefaulConnection")));

        services.AddScoped<IUsuarioService, UsuarioService>();
        services.AddScoped<GlobalExceptionHandler>();


    }
}