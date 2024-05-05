using Product.Management.Infrastructure.DependencyInjection;

namespace Product.Management.Configuration
{
    public static class DependencyInjectionSetup
    {
        public static void AddDependencyInjectionSetup(this IServiceCollection services, IConfiguration configuration)
        {
            DependencyInjection.RegisterServices(services,configuration);
        }
    }
}
