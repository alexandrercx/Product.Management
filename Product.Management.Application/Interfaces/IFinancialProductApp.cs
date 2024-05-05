using Product.Management.Application.ViewModel;
using Product.Management.Domain.Entity;

namespace Product.Management.Application.Interfaces
{
    public interface IFinancialProductApp
    {
        FinancialProductOutputModel AddFinancialProduct(AddFinancialProductInputModel financialProduct);

        bool UpdateFinancialProduct(UpdateFinancialProductInputModel financialProduct);

        List<GetFinancialProductOutputModel> GetFinancialProduct();
    }
}
