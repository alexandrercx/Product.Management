using Product.Management.Domain.Entity;
using Product.Management.Domain.Interface.Repository;

namespace Product.Management.Infrastructure.Repository
{
    public class FinancialProductRepository : Repository<FinancialProduct>, IFinancialProductRepository
    {
        public FinancialProductRepository(Context.AppContext appContext) : base(appContext)
        {
                
        }

        public FinancialProduct Add(FinancialProduct financialProduct)
        {
            Db.FinancialProducts.Add(financialProduct);
            return financialProduct;
        }

        public FinancialProduct Update(FinancialProduct financialProduct)
        {
            Db.FinancialProducts.Update(financialProduct);
            return financialProduct;
        }

        public FinancialProduct? GetById(int id)
        {
            return Db.FinancialProducts.FirstOrDefault(c => c.Id == id);
        }

        public List<FinancialProduct> Get()
        {
            return Db.FinancialProducts.ToList();
        }

        public void SaveChanges()
        {
            Db.SaveChanges();
        }




    }
}
