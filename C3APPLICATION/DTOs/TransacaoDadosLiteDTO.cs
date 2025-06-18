namespace C3APPLICATION.DTOs
{
    public class TransacaoDadosLiteDTO : BaseDTO
    {
        public DateTime TransacaoDadosDataCadastro { get; set; }
        public DateTime TransacaoDadosDataAtualizacao { get; set; }
        public int TransacaoId { get; set; }
        public string? CCusto { get; set; }
        public decimal TotalCliente { get; set; }
    }
}
