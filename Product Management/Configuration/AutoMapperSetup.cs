using Product.Management.Application.AutoMapper;

namespace Product.Management.Configuration
{
    public static class AutoMapperSetup
    {

        public static void AddAutoMapperSetup(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(ViewModelToDomain), typeof(DomainToViewModel));
        }
    }
}
