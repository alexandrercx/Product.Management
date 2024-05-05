using Microsoft.EntityFrameworkCore;

namespace Product.Management.Configuration
{
    public static class DataBaseSetup
    {
        public static void AddDataBaseSetup(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<Infrastructure.Context.AppContext>(options => options.UseSqlServer(configuration.GetConnectionString("SqlConnection")));
        }
    }
}
