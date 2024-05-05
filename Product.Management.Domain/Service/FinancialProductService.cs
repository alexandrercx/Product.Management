using Product.Management.Domain.Entity;
using Product.Management.Domain.Interface.Repository;
using Product.Management.Domain.Interface.Service;

namespace Product.Management.Domain.Service
{
    public class FinancialProductService : IFinancialProductService
    {
        private readonly IFinancialProductRepository _financialProductRepository;
        public FinancialProductService(IFinancialProductRepository financialProductRepository)
        {
            _financialProductRepository = financialProductRepository;
        }

        public FinancialProduct AddFinancialProduct(FinancialProduct financialProduct)
        {
            _financialProductRepository.Add(financialProduct);
            _financialProductRepository.SaveChanges();
            return financialProduct;
        }

        public bool UpdateFinancialProduct(FinancialProduct financialProductParam)
        {
            var financialProduct = _financialProductRepository.GetById(financialProductParam.Id);
            if (financialProduct == null)
            {
                throw new FormatException("Financial Product not found");
            }
            financialProduct.Ativo = financialProductParam.Ativo;
            financialProduct.Nome = financialProductParam.Nome;
            financialProduct.TaxaJurosAnual = financialProductParam.TaxaJurosAnual;
            financialProduct.AplicacaoMinima = financialProductParam.AplicacaoMinima;
            financialProduct.QtdCotaTotal = financialProductParam.QtdCotaTotal;
            financialProduct.QtdCotaAtual = financialProductParam.QtdCotaAtual;
            financialProduct.Carencia = financialProductParam.Carencia;
            financialProduct.Vencimento = financialProductParam.Vencimento;
            financialProduct.CaracteristicasAtivo = financialProductParam.CaracteristicasAtivo;
            financialProduct.Ativo = financialProductParam.Ativo;

            _financialProductRepository.Update(financialProduct);
            _financialProductRepository.SaveChanges();
            return true;
        }

        public List<FinancialProduct> GetFinancialProduct()
        {
            var financialProduct = _financialProductRepository.Get();
            if (financialProduct == null)
            {
                throw new FormatException("no products found");
            }
            return financialProduct;
        }
    }
}
