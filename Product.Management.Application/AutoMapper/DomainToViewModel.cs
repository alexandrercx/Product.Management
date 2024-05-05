using AutoMapper;
using Product.Management.Application.ViewModel;
using Product.Management.Domain.Entity;

namespace Product.Management.Application.AutoMapper
{
    public class DomainToViewModel : Profile
    {
        public DomainToViewModel()
        {
            CreateMap<FinancialProduct, FinancialProductOutputModel>();
            CreateMap<FinancialProduct, GetFinancialProductOutputModel>();            
        }
    }
}
