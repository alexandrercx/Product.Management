namespace Product.Management.Application.ViewModel
{
    public class UpdateFinancialProductInputModel
    {
        public int Id { get; set; }
        public required string Nome { get; set; }
        public decimal TaxaJurosAnual { get; set; }
        public required decimal AplicacaoMinima { get; set; }
        public required int QtdCotaTotal { get; set; }
        public required int QtdCotaAtual { get; set; }
        public DateTime Carencia { get; set; }
        public DateTime Vencimento { get; set; }
        public string? CaracteristicasAtivo { get; set; }
        public bool Ativo { get; set; }
    }
}
