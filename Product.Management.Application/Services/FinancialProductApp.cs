using AutoMapper;
using Product.Management.Application.Interfaces;
using Product.Management.Application.ViewModel;
using Product.Management.Domain.Entity;
using Product.Management.Domain.Interface.Service;

namespace Product.Management.Application.Services
{
    public class FinancialProductApp : IFinancialProductApp
    {
        private readonly IFinancialProductService _financialProductService;
        private readonly IMapper _mapper;
        public FinancialProductApp(IMapper mapper, IFinancialProductService financialProductService)
        {
            _mapper = mapper;
            _financialProductService = financialProductService;
        }

        public FinancialProductOutputModel AddFinancialProduct(AddFinancialProductInputModel financialProduct)
        {
            FinancialProduct fp = _mapper.Map<FinancialProduct>(financialProduct);
            _financialProductService.AddFinancialProduct(fp);
            FinancialProductOutputModel fpmodel = _mapper.Map<FinancialProductOutputModel>(fp);
            fpmodel.Message = "Success";
            return fpmodel;
        }

        public bool UpdateFinancialProduct(UpdateFinancialProductInputModel financialProduct)
        {
            FinancialProduct fp = _mapper.Map<FinancialProduct>(financialProduct);
            var response = _financialProductService.UpdateFinancialProduct(fp);
            return response;
        }

        public List<GetFinancialProductOutputModel> GetFinancialProduct()
        {
            var lstProd = _financialProductService.GetFinancialProduct();
            List<GetFinancialProductOutputModel> lstModel = _mapper.Map<List<GetFinancialProductOutputModel>>(lstProd);
            return lstModel;
        }

    }
}
