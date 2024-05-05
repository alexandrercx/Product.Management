using Product.Management.Domain.Entity;

namespace Product.Management.Domain.Interface.Service
{
    public interface IFinancialProductService
    {
        FinancialProduct AddFinancialProduct(FinancialProduct financialProduct);

        bool UpdateFinancialProduct(FinancialProduct financialProduct);

        List<FinancialProduct> GetFinancialProduct();
    }
}
