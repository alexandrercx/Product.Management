using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Product.Management.Application.Interfaces;
using Product.Management.Application.Services;
using Product.Management.Domain.Interface.Repository;
using Product.Management.Domain.Interface.Service;
using Product.Management.Domain.Service;
using Product.Management.Infrastructure.Repository;

namespace Product.Management.Infrastructure.DependencyInjection
{
    public static class DependencyInjection
    {
        public static void RegisterServices(IServiceCollection service, IConfiguration configuration)
        {
            //Application
            service.AddScoped<IFinancialProductApp, FinancialProductApp>();

            //Domain
            service.AddScoped<IFinancialProductService, FinancialProductService>();

            //Repository
            service.AddScoped<IFinancialProductRepository, FinancialProductRepository>();
        }
    }
}
