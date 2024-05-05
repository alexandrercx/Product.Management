using AutoMapper;
using Product.Management.Application.ViewModel;
using Product.Management.Domain.Entity;

namespace Product.Management.Application.AutoMapper
{
    public class ViewModelToDomain : Profile
    {
        public ViewModelToDomain()
        {
            CreateMap<AddFinancialProductInputModel, FinancialProduct>();
            CreateMap<UpdateFinancialProductInputModel, FinancialProduct>();
            
        }
    }
}
