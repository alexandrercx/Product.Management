using Product.Management.Domain.Entity;

namespace Product.Management.Domain.Interface.Repository
{
    public interface IFinancialProductRepository : IDisposable
    {
        FinancialProduct Add(FinancialProduct financialProduct);
        FinancialProduct Update(FinancialProduct financialProduct);
        FinancialProduct? GetById(int id);
        List<FinancialProduct> Get();
        void SaveChanges();
    }
}
